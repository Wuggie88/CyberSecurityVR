using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_Text assText;
    public TMP_Text timerText;
    public TMP_Text statusText;
    public TMP_Text urlScoreText;
    public TMP_Text usbScoreText;
    public TMP_Text ransomScoreText;
    public TextMeshProUGUI monitorText;

    public bool timeIsRunning = false;
    public bool usbDone = false;
    public bool usbCorrect = false;
    public bool urlDone = false;
    public bool urlCorrect = false;
    //public bool cleaningDone = false;
    //public bool cleaningCorrect = false;
    public bool ransomDone = false;
    public bool ransomCorrect = false;

    public int assDone = 0;

    public float timer = 0;
    public float minutes;
    public float seconds;
    public float miliSeconds;
    
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning) {
            timer += Time.deltaTime;
            displayTime(timer);
        }
    }

    void displayTime(float timer) {
        minutes = Mathf.FloorToInt(timer / 60);
        seconds = Mathf.FloorToInt(timer % 60);
        miliSeconds = (timer % 1) * 1000;
        timerText.text = string.Format("Timer: {0:00}:{1:00}:{2:000}", minutes, seconds, miliSeconds);
    }

    public void checkAssignments() {
        //check if assignments are done This should actually be in gamemanager script! 
        if (assDone < 3) {
            if (!usbDone) {
                //Put the usb assignment up on the screen
                monitorText.text = "Løs opgaven omkring USB, Find skærmen med et tal på";
            } else if (!urlDone) {
                //put the url assignment up on the screen
                monitorText.text = "Løs opgaven omkring URL, helpdesk kan eventuelt hjælpe";
            } else if (!ransomDone) {
                //put the ransomwarae assignment up on the screen
                monitorText.text = "Løs opgaven omkring ransomware, helpdesk kan eventuelt hjælpe";
            } else {
                //this should never be hit, as the first if should be hit, but if it's hit, open the door, freeze timer and update the status screen
                monitorText.text = "Alle opgaver løst";
                timeIsRunning = false;
            }

        } else {
            //Freeze timer, set the status screen and open the door
            monitorText.text = "Alle opgaver løst";
            timeIsRunning = false;

            if (usbCorrect) {
                usbScoreText.text = "Korrekt, det er vigtigt kun at bruge de USB enheder som ens IT afdeling har godkendt.";
            } else {
                usbScoreText.text = "Ikke korrekt, hvis man er i tvivl omkring om man kan bruge en USB enhed, er det altid bedst at spørge ens IT afdeling.";
            }

            if (urlCorrect) {
                urlScoreText.text = "Korrekt, det kan godt ligne at et link er det korrekte når man først kigger på det uden at være det, det er derfor vigtigt at man tager sig lidt tid og tjekker hvad for en hjemmeside linket egentlig fører til";
            } else {
                urlScoreText.text = "Ikke korrekt, det kan godt ligne at et link er det korrekte når man først kigger på det uden at være det, det er derfor vigtigt at man tager sig lidt tid og tjekker hvad for en hjemmeside linket egentlig fører til";
            }

            if (ransomCorrect) {
                ransomScoreText.text = "Korrekt, det er altid vigtigt at melde ransomware angreb til sin IT afdeling hurtigst muligt og få styr på ting som eksempelvis backups.";
            } else {
                ransomScoreText.text = "Ikke korrekt, det er sjældent en god ide at betale til ransomware, men uanset hvad skal man altid kontakte sin IT afdeling og melde ransomware hurtigst muligt og få hjælp på denne måde.";
            }
            door.transform.Rotate(0, 90, 0);
        }
    }
}
