using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int playerScore;

	// Use this for initialization
	void Start () {
        playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void tallyCube()
    {
        playerScore++;
    }
}
