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
        CubeScript cubeScript = collision.gameObject.GetComponent<CubeScript>();

        if (!cubeScript.pointTallied && cubeScript.isActive && collision.gameObject.tag.Equals("Cube"))
        {
            cubeScript.pointTallied = true;
            cubeScript.isActive = false;
            ScoreManager.GetComponent<ScoreScript>().tallyCube();
        }
    }
}
