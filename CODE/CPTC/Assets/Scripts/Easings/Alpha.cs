using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha : MonoBehaviour {

    private float iniAlpha;
    public float finalAlpha;
    public float framesDuration;
    private float framesCounter;
    public Image myImage;
    public AnimationCurve hyb;

    // Use this for initialization
    void Start()
    {

        myImage = GetComponent<Image>();
        iniAlpha = myImage.color.a;
        framesCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {

        framesCounter += Time.deltaTime;
                
        myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, Mathf.Lerp(iniAlpha, finalAlpha, hyb.Evaluate(framesCounter / framesDuration)));

        if(framesCounter >= framesDuration)
        {

            framesCounter = framesDuration;

        }
    }
}
