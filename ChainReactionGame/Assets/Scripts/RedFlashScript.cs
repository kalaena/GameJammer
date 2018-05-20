using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlashScript : MonoBehaviour {
    
    private bool lightOn;

	// Use this for initialization
	void Start () {
        Vector3 bombPos = this.gameObject.GetComponentInParent<Transform>().position;
        Vector3 camPos = GameObject.Find("CameraHolder").transform.position;
        Vector3 diffPos = camPos - bombPos;        

        
        this.gameObject.transform.LookAt(GameObject.Find("CameraHolder").transform);
        this.gameObject.transform.Translate(diffPos * 0.1f);
        lightOn = false;

        StartCoroutine(flash(0.3f, 1.0f));
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public IEnumerator flash(float timeOn, float timeOff)
    {
        while (true)
        {
            lightOn = !lightOn;

            if (lightOn)
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                yield return new WaitForSeconds(timeOn);
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                yield return new WaitForSeconds(timeOff);
            }

           
           
        }
        
    }
}
