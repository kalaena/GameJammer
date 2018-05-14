using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void bombPlaced() 
    {
        remainingBombs--;
        detonateButton.GetComponent<Button>().interactable = true;
    }

    public void detonateBombs() {
        foreach (GameObject bomb in bombsPlaced)
        {
            bomb.GetComponent<BombController>().explode();
        }
        bombsPlaced.Clear();
        detonateButton.GetComponent<Button>().interactable = false;
    }
}
