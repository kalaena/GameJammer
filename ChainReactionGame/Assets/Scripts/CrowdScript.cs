using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdScript : MonoBehaviour {

    public GameObject ScoreManager;
   
    public int clapThreshold, clapScore;

	// Use this for initialization
	void Start () {
       
        ScoreManager = GameObject.Find("ScoreManager");
        clapThreshold = 1000;
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.GetComponent<ScoreScript>().playerScore - clapScore >= clapThreshold)
        {
            clapScore += clapThreshold;         
            this.gameObject.GetComponent<AudioSource>().Play();
        }
		
	}
}
