using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BombCountUI : MonoBehaviour {

    public GameObject BombManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Text>().text = "Bombs: " + BombManager.GetComponent<BombManagerScript>().remainingBombs;
	}
}
