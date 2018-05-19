using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class BombManagerScript : MonoBehaviour {

    public int maxNumberOfBombsAllowed;
    public int remainingBombs;
    public GameObject detonateButton;
    
    public List<GameObject> bombsPlaced;

	// Use this for initialization
	void Start () {
        remainingBombs = maxNumberOfBombsAllowed = 3;
        bombsPlaced = new List<GameObject>();
        detonateButton.GetComponent<Button>().interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Enable the detonate button to be pressed and decrement the remaining bombs in the UI
    public void bombPlaced() 
    {
        remainingBombs--;
        detonateButton.GetComponent<Button>().interactable = true;
    }

    public void detonateBombs() {
        //Shake the camera when bombs are detonated, scaled off the number of bombs that exploded
        CameraShaker.Instance.ShakeOnce(5.0f * bombsPlaced.Count, 3.0f, 0.1f, 2.0f);
        
        //Explode each bomb placed in the level
        foreach (GameObject bomb in bombsPlaced) {
            bomb.GetComponent<BombController>().explode();            
        }

        //Remove the bombs from the list, deactivating the detonate button
        bombsPlaced.Clear();
        detonateButton.GetComponent<Button>().interactable = false;


    }
}
