using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [Tooltip("How big the button gets on mouse over, 1 is base size, 2 would be double size")]
    public float maxScale;
    public float minScale;

    public float scaleUpFactor;
    public float scaleDownFactor;

    public float pulseSpeed = 0.05f;

    public float originalScaleX;
    public float originalScaleY;

    bool isPulsing = false;
    bool isGrowing = false;

	// Use this for initialization
	void Start () {
        scaleUpFactor = 0.25f;
        scaleDownFactor = 0.05f;
        maxScale = gameObject.transform.localScale.x + scaleUpFactor;
        minScale = gameObject.transform.localScale.x - scaleDownFactor;

        originalScaleX = gameObject.transform.localScale.x;
        originalScaleY = gameObject.transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (isPulsing)
          pulse();
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        isPulsing = true;
        isGrowing = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPulsing = false;
        isGrowing = true;
        gameObject.transform.localScale = new Vector3(originalScaleX, originalScaleY, 1.0f);
    }

    void pulse() {
        if (isGrowing)
        {
            if (gameObject.transform.localScale.x < maxScale)
                gameObject.transform.localScale += new Vector3(pulseSpeed, pulseSpeed, 0);
            else
                isGrowing = false;
        }

        else
        {
            if (gameObject.transform.localScale.x > minScale)
                gameObject.transform.localScale -= new Vector3(pulseSpeed, pulseSpeed, 0);
            else
                isGrowing = true;
        }
    }
}
