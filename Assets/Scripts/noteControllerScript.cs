using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class noteControllerScript : MonoBehaviour
{
    [Header("UI Text")]
    [SerializeField] private GameObject NoteCanvas;
    [SerializeField] private TMP_Text CanvasText;

    [Space(10)]
    [SerializeField][TextArea] public string noteText;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;

    void Start() {
        NoteCanvas = GameObject.FindWithTag("cameraCanvas");
        CanvasText = GameObject.FindWithTag("canvasText").GetComponent<TMP_Text>();
    }


    public void ShowNote() {
        CanvasText.text = noteText;
        NoteCanvas.SetActive(true);
        openEvent.Invoke();
        isOpen = true;
    }

    public void DisableNote() {
        NoteCanvas.SetActive(false);
        CanvasText.text = null;
        isOpen = false;
    }
}
