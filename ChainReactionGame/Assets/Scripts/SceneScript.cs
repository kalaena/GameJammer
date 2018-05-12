using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

    public GameObject SoundManager;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        
	}
	
	// Update is called once per frame
	void Update () {
        if (SoundManager == null)
            GameObject.Destroy(this.gameObject);
	}

    public void loadScene(int sceneID) 
    {
        if (sceneID == 0 || sceneID == 2)
        {
            if (SoundManager != null)
                DontDestroyOnLoad(SoundManager);
        }
        SceneManager.LoadScene(sceneID);
    }
}
