using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnlocker : MonoBehaviour
{
    public GameObject ScoreManager;

    private SphereCollider _sphereCollider;
    private readonly static Vector3 _cascadeVector = new Vector3(0, 0.2f, 0);

    // Use this for initialization
    void Start()
    {
        ScoreManager = GameObject.Find("ScoreManager");
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        //cascade the cube destruction up the building and eventually self-cleanup
        if (transform.position.y < 30)
            transform.position += _cascadeVector;
        else
            Destroy(gameObject);

        //widen "explosion" radius of sphere as it climbs the building
        _sphereCollider.radius += 0.01f;
    }

    void OnTriggerEnter(Collider collision)
    {

        //if the cube unlocker hits a TNT charge, explode it after a short delay
        if (collision.gameObject.tag.Equals("TNT"))
        {
            StartCoroutine(collision.gameObject.GetComponent<TNTscript>().explode());
        }

        //if the object is not the ground (tag "Immobile") and the CubeUnlocker hasn't already tried unlocking in a previous frame
        else if (collision.gameObject.GetComponent<Rigidbody>() == null && !collision.gameObject.tag.Equals("Immobile"))
        {
            Rigidbody rb = collision.gameObject.AddComponent<Rigidbody>();
            //doesnt work
            //rb.AddExplosionForce(100, collision.gameObject.transform.position, 10, 10.0f);
            int randXforce = Random.Range(-7, 7);
            int randYforce = Random.Range(1, 5);
            int randZforce = Random.Range(-7, 7);
            rb.AddForce(randXforce, randYforce, randZforce, ForceMode.Impulse);
            ScoreManager.GetComponent<ScoreScript>().tallyCube();

            CubeScript cs = collision.gameObject.GetComponent<CubeScript>();
            if (cs != null)
            {
                cs.isActive = true;
            }
        }
    }
}
