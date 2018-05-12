using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform bombPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Cast a ray from mouse location
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //check if ray collides with something for us to place a bomb on (in this case the ground)
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //spawn a bomb at the clicked point
                Instantiate(bombPrefab, hit.point, Quaternion.identity);
            }
        }
    }
}
