using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RansomButtonScript : MonoBehaviour
{

    public GameObject gameManager;
    public TextMeshProUGUI monitorText;

    public void OnTriggerEnter(Collider other) {
        if(!gameManager.GetComponent<GameManager>().ransomDone) {
            gameManager.GetComponent<GameManager>().ransomDone = true;
            monitorText.text = "Ransom Paid";
            gameManager.GetComponent<GameManager>().assDone = gameManager.GetComponent<GameManager>().assDone + 1;
        }
    }
}
