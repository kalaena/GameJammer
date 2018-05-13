using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

    public GameObject SoundManager;

	// Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void loadScene(int sceneID) 
    {
        SceneManager.LoadScene(sceneID);
    }
}
