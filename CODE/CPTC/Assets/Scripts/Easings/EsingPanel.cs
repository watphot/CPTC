using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsingPanel : MonoBehaviour {

    public Vector2 initValue;
    public float framesDuration;
    public float framesDuration2;
    public float framesCounter;
    public float framesCounter2;
    public Image myImage;
    public GameObject finalPosition;
    public GameObject startPosition;
    public AnimationCurve hyb;
    public bool active;

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            active = !active;

            framesCounter = 0;
            framesCounter2 = 0;

        }

        if (active)
        {

            framesCounter += Time.deltaTime;

            myImage.rectTransform.position = Vector2.Lerp(initValue, finalPosition.transform.position, hyb.Evaluate(framesCounter / framesDuration));

            if (framesCounter >= framesDuration)
            {

                framesCounter = framesDuration;

            }

        }

        if (!active)
        {

            framesCounter2 += Time.deltaTime;

            myImage.rectTransform.position = Vector2.Lerp(myImage.rectTransform.position, startPosition.transform.position, hyb.Evaluate(framesCounter2 / framesDuration2));

            if (framesCounter2 >= framesDuration2)
            {

                framesCounter2 = framesDuration2;

            }

        }
        
    }
}
