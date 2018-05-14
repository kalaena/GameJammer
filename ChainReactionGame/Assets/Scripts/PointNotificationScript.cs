using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointNotificationScript : MonoBehaviour {

    public GameObject pointUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void createNotification(int numPoints, Vector3 pos)
    {
        GameObject notification = Instantiate(pointUI, pos, Quaternion.identity).gameObject;
        notification.GetComponent<PointUIScript>().setPointValue(numPoints);
        notification.transform.LookAt(GameObject.Find("Main Camera").transform.position);
    }
}
