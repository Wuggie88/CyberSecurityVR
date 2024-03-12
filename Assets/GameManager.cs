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

    public bool timeIsRunning = false;

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
