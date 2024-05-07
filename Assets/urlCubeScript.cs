using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class urlCubeScript : MonoBehaviour
{
    public noteControllerScript _noteController;

    [Space(10)]
    [SerializeField][TextArea] public string noteText;

    [Header("Correct Cube bool")]
    [SerializeField] public bool correctAnswer;


    void Awake() {
        _noteController = this.GetComponent<noteControllerScript>();
    }

    // Start is called before the first frame update
    void Start() {
        _noteController.noteText = noteText;
    }
}
