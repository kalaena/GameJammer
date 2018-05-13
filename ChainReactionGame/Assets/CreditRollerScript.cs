using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditRollerScript : MonoBehaviour {

    bool scrollDone;
    public GameObject MainMenuButton;

	// Use this for initialization
	void Start () {
        scrollDone = false;
	}
	
	// Update is called once per frame
	void Update () {        
        if (this.transform.localPosition.y < -100)
            this.transform.Translate(0, 3, 0);
        else
            scrollDone = true;        

        if (scrollDone && !MainMenuButton.activeSelf)
            MainMenuButton.SetActive(true);
	}
}
