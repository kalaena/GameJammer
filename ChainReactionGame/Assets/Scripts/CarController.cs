using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float LeftEdgeOfMap = -7.5f;
    public float RightEdgeOfMap = 7.5f;

    const float speed = 1.5f;

    // Use this for initialization
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f, 0.0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        //reset position when off the map
        if (gameObject.transform.position.z > RightEdgeOfMap)
        {
            gameObject.transform.position = new Vector3(-0.206f, 0.128f, LeftEdgeOfMap);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //we have gravity off by default so we can drive by without being all wierd, but on collision we need to turn it on so we don't float out into space
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }
}
