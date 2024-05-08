using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RansomAssScript : MonoBehaviour
{
    public GameObject gameManager;
    public TextMeshProUGUI monitorText;

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "USBRansom") {
            monitorText.text = "Data was restored";
            gameManager.GetComponent<GameManager>().ransomDone = true;
            gameManager.GetComponent<GameManager>().ransomCorrect = true;
            gameManager.GetComponent<GameManager>().assDone = gameManager.GetComponent<GameManager>().assDone + 1;
        }
    }
}
