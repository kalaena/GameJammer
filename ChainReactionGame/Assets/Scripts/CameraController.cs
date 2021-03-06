﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20.0f; //Camera speed for keyboard camera controls. Can be adjusted in Unity.
    public float panBorderThickness = 10.0f; //Used for moving the camera with mouse cursor to the edge of the screen. Can be adjusted in Unity.
    public Vector2 panLimit = new Vector2(7.5f, 7.5f); //Creates a limited area of where the camera can move.

    public float scrollSpeed = 18.0f; //Setting zoom speed of camera. Can be adjusted in Unity.
    public float minY = 4.0f; //Setting min. Y axis movement of camera.
    public float maxY = 10.0f; //Setting max. Y axis movement of camera.

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // Moving camera with the WSDA on the keyboard or panning with the mouse cursor to the screen boarder.

        if (Input.GetKey("d") || Input.mousePosition.x >= (Screen.width - panBorderThickness))
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
       /*
        else if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("w") || Input.mousePosition.y >= (Screen.height - panBorderThickness))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        
      ///  float scroll = Input.GetAxis("Mouse ScrollWheel"); // Allows the scroll wheel to move on the Y axis at a set speed.
        ///if (scroll != 0.0f)
        //{
          //  pos.z -= scroll * scrollSpeed * 100f * Time.deltaTime;
        //}

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x); //Sets X axis movement of the camera. Can be adjusted in Unity.
        //pos.y = Mathf.Clamp(pos.y, minY, maxY); //Clamps camera zoom.
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y); //Sets Z axis movement of the camera. Can be adjusted in Unity.
        */
        transform.position = pos; //Moves camera. 
    }
}
