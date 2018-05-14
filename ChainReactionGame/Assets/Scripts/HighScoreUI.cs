using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour {

    public GameObject DataController;

	// Use this for initialization
	void Start () {
        refreshHighScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void refreshHighScore()
    {
        this.gameObject.GetComponent<Text>().text = "High Score: " + DataController.GetComponent<DataController>().GetHighestPlayerScore();
    }
}
