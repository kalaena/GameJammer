using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour {

    public GameObject sceneManager;

    [HideInInspector]
    public SceneScript sceneScript;

    // Use this for initialization
    void Start()
    {
        sceneManager = GameObject.Find("SceneManager");
        sceneScript = sceneManager.GetComponent<SceneScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMainMenu()
    {
        sceneScript.loadScene(0);
    }
}
