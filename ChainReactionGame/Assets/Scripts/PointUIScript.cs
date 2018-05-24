using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUIScript : MonoBehaviour {

    public int pointValue;
    public float originalYposition;
    public float lifetime;


	// Use this for initialization
	void Start () {
		pointValue = 0;
        originalYposition = this.gameObject.transform.position.y;
        lifetime = 1.5f;
	}
	
	// Update is called once per frame
    void Update()
    {
        //slowly move up until death
        this.gameObject.transform.Translate(new Vector3(0, 0.008f, 0));
        //if (this.gameObject.transform.position.y - originalYposition > 5)
            //GameObject.Destroy(this.gameObject);
        if (lifetime <= 0)
            GameObject.Destroy(this.gameObject);
        lifetime -= Time.deltaTime;

    }

    public void setPointValue(int pointValue) 
    {
        this.gameObject.GetComponent<TextMesh>().text = "Car Bonus +" + pointValue;
    }
}
