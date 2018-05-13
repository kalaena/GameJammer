using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject cubeUnlocker;

    private GameObject explosionInstance;

    // Use this for initialization
    void Start()
    {
        //set bomb to explode
        StartCoroutine(explode());

        //set explosion to be cleaned up
        StartCoroutine(cleanupExplosion());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator explode()
    {
        yield return new WaitForSeconds(2);

        //create explosion at our bomb's location
        explosionInstance = Instantiate(explosionPrefab, transform.position, Quaternion.Euler(0, 90, 0));
        explosionInstance.transform.LookAt(GameObject.Find("Main Camera").transform.position);

        //create a sphere collider that adds rigidbody collision to all cubes it touches
        cubeUnlocker = Instantiate(cubeUnlocker, transform.position, Quaternion.Euler(0, 90, 0));
        

        //we can't destroy the game object just yet, because we have to wait for the explosion to cleanup... so move it out of view for a moment until we destroy it
        gameObject.transform.position = new Vector3(999, 999, 999);
    }

    private IEnumerator cleanupExplosion()
    {
        yield return new WaitForSeconds(3);

        //destroy this explosion
        Destroy(explosionInstance);

        //destroy this bomb
        Destroy(gameObject);
    }
}
