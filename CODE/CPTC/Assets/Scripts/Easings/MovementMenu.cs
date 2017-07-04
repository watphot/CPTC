using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementMenu : MonoBehaviour {

    public Vector2 initValue;
    public Vector2 initValue2;
    public Vector2 initValue3;
    public float framesDuration;
    public float framesDuration2;
    public float framesDuration3;
    private float framesCounter;
    private float framesCounter2;
    private float framesCounter3;
    public Button myImage;
    public Button myImage2;
    public Button myImage3;
    public GameObject finalPositionStart;
    public GameObject finalPositionIndex;
    public GameObject finalPositionQuit;
    public AnimationCurve hyb;

    //Alpha

    public float iniAlpha;
    public float finalAlpha;
    public float framesDuration4;
    public float framesCounter4;
    public Image myImage4;

    public float timeDurationActive;
    public bool active;
    private float timeToActive;
    

    // Use this for initialization
    void Start()
    {

        initValue = myImage.transform.position;
        initValue2 = myImage2.transform.position;
        initValue3 = myImage3.transform.position;
        framesCounter = 0;
        framesCounter2 = 0;
        framesCounter3 = 0;

        iniAlpha = myImage4.color.a;
        framesCounter4 = 0;


    }

    // Update is called once per frame
    void Update()
    {

        timeToActive += Time.deltaTime;

        if (timeToActive >= timeDurationActive)
        {

            active = true;

            timeToActive = timeDurationActive;

        }

        if (active)
        {

            //Start

            framesCounter += Time.deltaTime;

            myImage.transform.position = Vector2.Lerp(initValue, finalPositionStart.transform.position, hyb.Evaluate(framesCounter / framesDuration));

            if (framesCounter >= framesDuration)
            {

                framesCounter = framesDuration;

            }

            //Index

            framesCounter2 += Time.deltaTime;

            myImage2.transform.position = Vector2.Lerp(initValue2, finalPositionIndex.transform.position, hyb.Evaluate(framesCounter2 / framesDuration2));

            if (framesCounter2 >= framesDuration2)
            {

                framesCounter2 = framesDuration2;

            }

            //Quit

            framesCounter3 += Time.deltaTime;

            myImage3.transform.position = Vector2.Lerp(initValue3, finalPositionQuit.transform.position, hyb.Evaluate(framesCounter3 / framesDuration3));

            if (framesCounter3 >= framesDuration3)
            {

                framesCounter3 = framesDuration3;

            }

            //LOGO

            framesCounter4 += Time.deltaTime;

            myImage4.color = new Color(myImage4.color.r, myImage4.color.g, myImage4.color.b, Mathf.Lerp(iniAlpha, finalAlpha, hyb.Evaluate(framesCounter4 / framesDuration4)));

            if (framesCounter4 >= framesDuration4)
            {

                framesCounter4 = framesDuration4;

            }

        }

    }
}