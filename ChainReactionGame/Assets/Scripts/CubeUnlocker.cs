using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnlocker : MonoBehaviour {

    public GameObject ScoreManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //cascade the cube destruction up the building and eventually self-cleanup
        if (transform.position.y < 30)
            transform.position += new Vector3(0, 0.2f, 0);
        else
            GameObject.Destroy(this.gameObject);

        //widen "explosion" radius of sphere as it climbs the building
        this.gameObject.GetComponent<SphereCollider>().radius += 0.01f;
	}

    void OnTriggerEnter(Collider collision)
    {
        //if the object is not the ground (tag "Immobile") and the CubeUnlocker hasn't already tried unlocking in a previous frame
        if (!collision.gameObject.tag.Equals("Immobile") && collision.gameObject.GetComponent<Rigidbody>() == null)
        {
            collision.gameObject.AddComponent<Rigidbody>();
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(50, collision.gameObject.transform.position, 100, 1.0f);
            ScoreManager.GetComponent<ScoreScript>().tallyCube();
            collision.gameObject.GetComponent<CubeScript>().isActive = true;
        }
            
    }
}
