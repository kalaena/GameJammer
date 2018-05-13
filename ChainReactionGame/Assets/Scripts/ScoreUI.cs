using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public GameObject ScoreManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Text>().text = "Score: " + ScoreManager.GetComponent<ScoreScript>().playerScore;
	}
}
