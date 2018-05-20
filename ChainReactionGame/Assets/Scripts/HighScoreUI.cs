using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour {

    public GameObject DataController;
    public GameObject ScoreManager;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Text>().text = "High Score: " + DataController.GetComponent<DataController>().GetHighestPlayerScore();
	}

}
