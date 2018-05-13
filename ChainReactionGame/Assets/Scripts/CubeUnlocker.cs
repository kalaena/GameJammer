using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnlocker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //cascade the cube destruction up the building and eventually self-cleanup
        if (transform.position.y < 30)
            transform.position += new Vector3(0, 0.1f, 0);
        else
            GameObject.Destroy(this.gameObject);

        //widen "explosion" radius of sphere as it climbs the building
        this.gameObject.GetComponent<SphereCollider>().radius += 0.015f;
	}

    void OnTriggerEnter(Collider collision)
    {
        //if the object is not the ground (tag "Immobile") and the CubeUnlocker hasn't already tried unlocking in a previous frame
        if (!collision.gameObject.tag.Equals("Immobile") && collision.gameObject.GetComponent<Rigidbody>() == null)
        {
            collision.gameObject.AddComponent<Rigidbody>();
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(15, this.gameObject.transform.position, 3, 1.0f);
        }
            
    }
}
