using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class USBAss : MonoBehaviour
{

    public TextMeshProUGUI MonitorText;
    public int AssNumber;
    public GameObject correctUSB;
    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(initiate());
    }

    public void OnTriggerEnter(Collider target) {
        if(target.tag == "USB") {
            GameManager.GetComponent<GameManager>().assDone = GameManager.GetComponent<GameManager>().assDone + 1;
            GameManager.GetComponent<GameManager>().usbDone = true;
            if (target.name == correctUSB.name) {
                MonitorText.text = "Success!";
                this.GetComponent<Collider>().enabled = false;
                GameManager.GetComponent<GameManager>().usbCorrect = true;
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
                AssNumber = 57;
                //Blue USB
                correctUSB = GameObject.Find("USB_Blue");
                MonitorText.text = AssNumber.ToString();
                break;
            case 2:
                AssNumber = 29;
                //Red USB
                correctUSB = GameObject.Find("USB_Red");
                MonitorText.text = AssNumber.ToString();
                break;
            case 3:
                AssNumber = 17;
                //Green USB
                correctUSB = GameObject.Find("USB_Green");
                MonitorText.text = AssNumber.ToString();
                break;
            case 4:
                AssNumber = 92;
                //Purple USB
                correctUSB = GameObject.Find("USB_Purple");
                MonitorText.text = AssNumber.ToString();
                break;
            case 5:
                AssNumber = 63;
                //Yellow USB
                correctUSB = GameObject.Find("USB_Yellow");
                MonitorText.text = AssNumber.ToString();
                break;
            default:
                AssNumber = 92;
                //Purple USB
                correctUSB = GameObject.Find("USB_Purple");
                MonitorText.text = AssNumber.ToString();
                break;
        }


    }
}
