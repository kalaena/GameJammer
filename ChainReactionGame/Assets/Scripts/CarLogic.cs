using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour
{
    private float _leftEdgeOfMap;
    private float _rightEdgeOfMap;

    private GameObject _carController;
    private bool direction; //true = spawned at right and moving left

    // Use this for initialization
    void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        direction = rb.velocity.z < 0.0f;

        _carController = GameObject.Find("CarController");
        _leftEdgeOfMap = _carController.GetComponent<CarController>().LeftEdgeOfMap;
        _rightEdgeOfMap = _carController.GetComponent<CarController>().RightEdgeOfMap;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
        {
            if (gameObject.transform.position.z <= _leftEdgeOfMap)
            {
                //off edge of map so destroy and notify car controller
                _carController.GetComponent<CarController>().OnCarDestroy(gameObject);
                Destroy(gameObject);
            }
        }
        else
        {
            if (gameObject.transform.position.z >= _rightEdgeOfMap)
            {
                //off edge of map so destroy and notify car controller
                _carController.GetComponent<CarController>().OnCarDestroy(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
