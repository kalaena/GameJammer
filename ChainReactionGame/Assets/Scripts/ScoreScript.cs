using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int playerScore;
    public int highScore;
    public GameObject dataController;
    public GameObject PointNotifier;

	// Use this for initialization
	void Start () {
        playerScore = 0;
        //refreshHighScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void refreshHighScore() 
    {
        dataController.GetComponent<DataController>().loadPlayerProgress();
        highScore = dataController.GetComponent<DataController>().GetHighestPlayerScore();
    }

    public void tallyCube()
    {
        playerScore++;        
    }

    public void tallyCar(Vector3 pos) 
    {
        playerScore += 50;
        PointNotifier.GetComponent<PointNotificationScript>().createNotification(50, pos);
    }
}
