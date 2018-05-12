using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoeysPlaygroundButton : MonoBehaviour {

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

   public void LoadJoeysPlayground() {
       sceneScript.loadScene(1);
    }
}
