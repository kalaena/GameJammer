using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int scalar = 5;
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(1,3), Random.Range(1,3), Random.Range(1,3)) * scalar);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
