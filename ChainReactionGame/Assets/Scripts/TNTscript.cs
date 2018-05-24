using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTscript : MonoBehaviour {


    public GameObject explosionPrefab;
    public GameObject cubeUnlocker;
    public GameObject smokeEmitter;

    private GameObject explosionInstance;

	// Use this for initialization
	void Start () {
		
	}

    public IEnumerator explode()
    {
        //delay explosion to simulate a fuse - chain effect
        yield return new WaitForSeconds(.3f);

        //play bomb explosion sound
        this.gameObject.GetComponent<AudioSource>().Play();

        //create explosion at our bomb's location
        explosionInstance = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        //create smoke emitter standing upright at bomb's location
        GameObject smoke = Instantiate(smokeEmitter, transform.position, Quaternion.identity);
        smoke.transform.Rotate(-90, 0, 0);

        //turn the explosion to look at the camera
        explosionInstance.transform.LookAt(GameObject.Find("Main Camera").transform.position);

        //create a sphere collider that adds rigidbody collision to all cubes it touches
        cubeUnlocker = Instantiate(cubeUnlocker, transform.position, Quaternion.identity);

        //we can't destroy the game object just yet, because we have to wait for the explosion to cleanup... so move it out of view for a moment until we destroy it
        gameObject.transform.position = new Vector3(999, 999, 999);

        //set explosion to be cleaned up
        StartCoroutine(cleanupExplosion());
    }

    private IEnumerator cleanupExplosion()
    {
        yield return new WaitForSeconds(.25f);

        //destroy this explosion
        Destroy(explosionInstance);

        //destroy this TNT
        Destroy(gameObject);

        //DO NOT DESTROY SMOKE EMITTER
    }
}
