using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUIScript : MonoBehaviour {

    public int pointValue;
    public float originalYposition;
    public const float fadeSpeed = 3;

	// Use this for initialization
	void Start () {
		pointValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //slowly move up until death
        this.gameObject.transform.Translate(new Vector3(0,1,0));
        if (this.gameObject.transform.position.y - originalYposition > 5)
            GameObject.Destroy(this.gameObject);

        Text text = this.gameObject.GetComponent<Text>();
        //fade away
        if (text.color != Color.clear)
            Color.Lerp(text.color, Color.clear, fadeSpeed * Time.deltaTime);

	}

    public void setPointValue(int pointValue) 
    {
        this.gameObject.GetComponent<Text>().text = "+ " + pointValue;
    }
}
