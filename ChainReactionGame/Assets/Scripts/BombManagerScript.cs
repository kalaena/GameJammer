using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManagerScript : MonoBehaviour {

    public int maxNumberOfBombsAllowed;
    public int remainingBombs;

    public List<GameObject> bombsPlaced;

	// Use this for initialization
	void Start () {
        remainingBombs = maxNumberOfBombsAllowed = 3;
        bombsPlaced = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bombPlaced() 
    {
        remainingBombs--;
    }

    public void detonateBombs() {
        foreach (GameObject bomb in bombsPlaced)
        {
            bomb.GetComponent<BombController>().explode();
        }
        bombsPlaced.Clear();
    }
}
