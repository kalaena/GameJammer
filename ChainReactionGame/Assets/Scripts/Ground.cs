using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject ScoreManager;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        //if a cube hits the ground
        if (collision.gameObject.tag.Equals("Cube"))
        {
            //check if the cube has already been scored, also avoid cubes that haven'g been activated by a bomb (the ones that spawn at ground level)
            CubeScript cubeScript = collision.gameObject.GetComponent<CubeScript>();
            if (!cubeScript.pointTallied && cubeScript.isActive)
            {
                cubeScript.pointTallied = true;
                cubeScript.isActive = false;
                ScoreManager.GetComponent<ScoreScript>().tallyCube();
            }
        }
    }
}
