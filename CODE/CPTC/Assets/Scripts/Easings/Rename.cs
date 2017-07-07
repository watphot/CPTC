using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rename : MonoBehaviour {

    private Vector2 initValue;
    public float framesDuration;
    private float framesCounter;
    private Image myImage;
    public GameObject finalPosition;
    public AnimationCurve hyb;

    // Use this for initialization
    void Start()
    {

        myImage = GetComponent<Image>();
        initValue = myImage.rectTransform.position;
        framesCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {

            framesCounter += Time.deltaTime;

            myImage.rectTransform.position = Vector2.Lerp(initValue, finalPosition.transform.position, hyb.Evaluate(framesCounter / framesDuration));

            if(framesCounter >= framesDuration)
            {

                framesCounter = framesDuration;

            }
    }
}

