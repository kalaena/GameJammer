using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int playerScore;
    public int highScore;
    public DataController dataController;

	// Use this for initialization
	void Start () {
        playerScore = 0;
        refreshHighScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void refreshHighScore() 
    {
        dataController.loadPlayerProgress();
        highScore = dataController.GetHighestPlayerScore();
    }

    public void tallyCube()
    {
        playerScore++;        
    }
}
