﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public Transform bombPrefab;

    public GameObject BombManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //handle mouse clicks
        if (Input.GetButtonDown("Fire1") && BombManager.GetComponent<BombManagerScript>().remainingBombs > 0)
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                //UI was clicked... nothing to do here
                return;
            }

            // Cast a ray from mouse location
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //check if ray collides with something for us to place a bomb on (in this case the ground)
            RaycastHit[] hits = Physics.RaycastAll(ray, 100.0f);
            foreach (RaycastHit hit in hits)
            {
                BombManager.GetComponent<BombManagerScript>().bombPlaced();

                //spawn a bomb at the clicked point
                Vector3 bombLocation = hit.point + new Vector3(0, 0.2f, 0);
                GameObject bomb = Instantiate(bombPrefab, bombLocation, Quaternion.identity).gameObject;
                BombManager.GetComponent<BombManagerScript>().bombsPlaced.Add(bomb);


                //play sfx when placing bomb
                this.gameObject.GetComponent<AudioSource>().Play();

                break;
            }
        }
    }
}
