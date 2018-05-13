using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnlocker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 100)
            transform.position += new Vector3(0, 0.1f, 0);
        else
            GameObject.Destroy(this.gameObject);
	}

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("collided");
        if (!collision.gameObject.tag.Equals("Immobile") && collision.gameObject.GetComponent<Rigidbody>() == null)
        {
            collision.gameObject.AddComponent<Rigidbody>();
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(25, this.gameObject.transform.position, 15, 1.0f);
        }
            
    }
}
