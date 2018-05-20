using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlashScript : MonoBehaviour {
    
    private bool lightOn;

	// Use this for initialization
	void Start () {
        lightOn = false;
        StartCoroutine(flash(0.25f, 1.25f));
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
                this.gameObject.GetComponent<MeshRenderer>().enabled = true;
                yield return new WaitForSeconds(timeOn);
            }
            else
            {
                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                yield return new WaitForSeconds(timeOff);
            }           
        }        
    }
}
