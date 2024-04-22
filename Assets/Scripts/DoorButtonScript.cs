using System.Collections;
using UnityEngine;
using TMPro;

public class DoorButtonScript : MonoBehaviour
{

    public GameObject gameManager;
    public TextMeshProUGUI monitorText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        StartCoroutine(test());
    }

    //do things when other things collide with the button
    public void OnTriggerEnter(Collider other) {

        //check if assignments are done
        if(gameManager.GetComponent<GameManager>().assDone < 4) {
            if (!gameManager.GetComponent<GameManager>().usbDone) {
                //Put the usb assignment up on the screen
                monitorText.text = "Løs opgaven omkring USB, helpdesk kan eventuelt hjælpe";
            } else if(!gameManager.GetComponent<GameManager>().urlDone) {
                //put the url assignment up on the screen
                monitorText.text = "Løs opgaven omkring URL, helpdesk kan eventuelt hjælpe";
            } else if (!gameManager.GetComponent<GameManager>().cleaningDone) {
                //Put the Cleaning assignment up on the screen
                monitorText.text = "Ryd op på skrivebordene, helpdeks kan eventuelt hjælpe med hvad.";
            } else if (!gameManager.GetComponent<GameManager>().ransomDone) {
                //put the ransomwarae assignment up on the screen
                monitorText.text = "Løs opgaven omkring ransomware, helpdesk kan eventuelt hjælpe";
            } else {
                //this should never be hit, as the first if should be hit, but if it's hit, open the door, freeze timer and update the status screen
                monitorText.text = "Alle opgaver løst";
                gameManager.GetComponent<GameManager>().timeIsRunning = false;
            }

        } else {
            //Freeze timer, set the status screen and open the door
            monitorText.text = "Alle opgaver løst";
            gameManager.GetComponent<GameManager>().timeIsRunning = false;
        }
        
    }

    IEnumerator test() {
        yield return new WaitForSeconds(5);
        gameManager.GetComponent<GameManager>().assDone = gameManager.GetComponent<GameManager>().assDone + 1;
        monitorText.text = "Løs opgaven omkring USB, helpdesk kan eventuelt hjælpe";
        gameManager.GetComponent<GameManager>().usbDone = true;
        gameManager.GetComponent<GameManager>().timeIsRunning = false;
    }


}
