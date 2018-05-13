using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreditsButton : MonoBehaviour {

    public GameObject sceneManager;

    [HideInInspector]
    public SceneScript sceneScript;

	// Use this for initialization
	void Start () {       
        sceneScript = sceneManager.GetComponent<SceneScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevelSelect()
    {
        sceneScript.loadScene(3);
    }
}
