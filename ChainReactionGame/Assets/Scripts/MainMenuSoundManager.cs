using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSoundManager : MonoBehaviour {

    public AudioSource themeSong;

	// Use this for initialization
	void Start () {
        if (themeSong.isPlaying)
            GameObject.Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
