using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class URLAssScript : MonoBehaviour
{

    public TextMeshProUGUI MonitorText;
    public GameObject GameManager;


    public void OnTriggerEnter(Collider target) {
        if (target.tag == "URL") {
            GameManager.GetComponent<GameManager>().assDone = GameManager.GetComponent<GameManager>().assDone + 1;
            GameManager.GetComponent<GameManager>().urlDone = true;
            if (target.GetComponent<urlCubeScript>().correctAnswer) {
                MonitorText.text = "Success!";
                this.GetComponent<Collider>().enabled = false;
                GameManager.GetComponent<GameManager>().urlCorrect = true;
                //find all URL objects and delete them
                GameObject[] gos = GameObject.FindGameObjectsWithTag("URL");
                foreach (GameObject go in gos)
                    Destroy(go);
            } else {
                MonitorText.text = "Error";
                this.GetComponent<Collider>().enabled = false;
                //find all URL objects and delete them
                GameObject[] gos = GameObject.FindGameObjectsWithTag("URL");
                foreach (GameObject go in gos)
                    Destroy(go);
            }
        }
    }
}
