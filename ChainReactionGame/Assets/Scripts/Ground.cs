using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

    public GameObject ScoreManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Cube") 
            && !collision.gameObject.GetComponent<CubeScript>().pointTallied
            && collision.gameObject.GetComponent<CubeScript>().isActive)
        {
            collision.gameObject.GetComponent<CubeScript>().pointTallied = true;
            collision.gameObject.GetComponent<CubeScript>().isActive = false;
            ScoreManager.GetComponent<ScoreScript>().tallyCube();
        }
    }
}
