using System.Collections;
using UnityEngine;
using TMPro;

public class DoorButtonScript : MonoBehaviour
{

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    //do things when other things collide with the button
    public void OnTriggerEnter(Collider other) {
        gameManager.GetComponent<GameManager>().checkAssignments();
        
    } 
}
