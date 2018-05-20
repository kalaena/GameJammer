using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int playerScore;
    public int highScore;
    private int carScore;
    public GameObject dataController;
    public GameObject PointNotifier;

	// Use this for initialization
	void Start () {
        playerScore = 0;
        carScore = 50;
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
        dataController.GetComponent<DataController>().SubmitNewPlayerScore(playerScore); 
    }

    public void tallyCar(Vector3 pos) 
    {
        playerScore += carScore;        
        dataController.GetComponent<DataController>().SubmitNewPlayerScore(playerScore);

        //create notification in game world
        PointNotifier.GetComponent<PointNotificationScript>().createNotification(carScore, pos);
    }
}
