using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    private Vector3 _InitialRotation;
    public Vector3 FinalRotation;

    public Quaternion InitialAngle;

    public GameObject ObjectToRotate;
    public Transform ObjectReference;

    public AnimationCurve Hyb;

    public float FramesDuration;
    public float FramesCounter;

    public bool Active;

    // Use this for initialization
    void Start () {

        InitialAngle = ObjectToRotate.transform.localRotation;

	}
	
	// Update is called once per frame
	void Update () {

        if (Active)
        {

            FramesCounter += Time.deltaTime;

            ObjectToRotate.transform.Rotate(Vector3.Lerp(_InitialRotation, FinalRotation, Hyb.Evaluate(FramesCounter / FramesDuration)));

            if (FramesCounter >= FramesDuration)
            {

                FramesCounter = FramesDuration;

            }

        }

        if (!Active)
        {

            //ObjectToRotate.transform.localRotation = ObjectReference.transform.localRotation;

            ObjectToRotate.transform.localRotation = InitialAngle;

        }

	}
}
