using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class URLAssScript : MonoBehaviour
{

    public TextMeshProUGUI MonitorText;
    public int AssNumber;
    public string correctURL;
    public GameObject GameManager;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(initiate());
    }

    public void OnTriggerEnter(Collider target) {
        if (target.tag == "URL") {
            GameManager.GetComponent<GameManager>().assDone = GameManager.GetComponent<GameManager>().assDone + 1;
            GameManager.GetComponent<GameManager>().urlDone = true;
            if (target.name == correctURL) {
                MonitorText.text = "Success!";
                this.GetComponent<Collider>().enabled = false;
                GameManager.GetComponent<GameManager>().urlCorrect = true;
            } else {
                MonitorText.text = "Error";
                this.GetComponent<Collider>().enabled = false;
            }
        }
    }


    IEnumerator initiate() {
        AssNumber = Random.Range(1, 6);
        yield return new WaitForEndOfFrame();
        switch (AssNumber) {
            case 1:
                correctURL = "";
                MonitorText.text = "";
                break;
            case 2:
                correctURL = "";
                MonitorText.text = "";
                break;
            case 3:
                correctURL = "";
                MonitorText.text = "";
                break;
            case 4:
                correctURL = "";
                MonitorText.text = "";
                break;
            case 5:
                correctURL = "";
                MonitorText.text = "";
                break;
            default:
                correctURL = "";
                MonitorText.text = "";
                break;
        }


    }
}
