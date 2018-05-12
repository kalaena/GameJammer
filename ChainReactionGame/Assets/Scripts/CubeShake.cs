using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShake : MonoBehaviour {

    [Tooltip("How much force is applied to the GameObject on Start")]
    public int forceScalar = 3; 
    
    void Start () {      
        //at runtime, randomly generate force and increase it by a factor of forceScalar
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(1,3), Random.Range(1,3), Random.Range(1,3)) * forceScalar);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
