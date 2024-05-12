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
}
