using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_Alpha : MonoBehaviour {

    public Material TestingMaterial;
    public Material TestingMaterial2;
    public Material TestingMaterial3;

    public Slider Slider;
    public float alpha;

    public CameraBehavior camera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        TestingMaterial.color = new Color(TestingMaterial.color.r, TestingMaterial.color.g, TestingMaterial.color.b, alpha);
        TestingMaterial3.color = new Color(TestingMaterial3.color.r, TestingMaterial3.color.g, TestingMaterial3.color.b, alpha);

        alpha = Slider.value;

        if (alpha == 1)
        {

            TestingMaterial.CopyPropertiesFromMaterial(TestingMaterial2);

        }

        else
        {

            TestingMaterial.CopyPropertiesFromMaterial(TestingMaterial3);

        }

    }

    public void DesactiveCamera()
    {

        camera.enabled = false;

    }

    public void ActiveCamera()
    {

        camera.enabled = true;

    }

}
