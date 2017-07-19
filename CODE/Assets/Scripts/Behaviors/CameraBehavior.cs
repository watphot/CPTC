using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {

    public Transform Target;

    private Vector3 StartPosition;
    private Vector3 mouseOrigin;

    private Quaternion _StartRotation;

    public float RotationSpeed;
    public float PanningSpeed;
    public float SmoothZoomSpeed;
        
    private bool _IsPanning;
    private bool _IsRotating;

    // Use this for initialization
    void Start () {

        StartPosition = transform.position;

        _StartRotation = transform.localRotation;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {

            mouseOrigin = Input.mousePosition;
            _IsRotating = true;
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            
            mouseOrigin = Input.mousePosition;
            _IsPanning = true;

        }

        if (!Input.GetMouseButton(0)) _IsRotating = false;
        if (!Input.GetMouseButton(1)) _IsPanning = false;
        
        if (_IsPanning)
        {

            if ((Input.GetAxis("Mouse X") != 0) || (Input.GetAxis("Mouse Y") != 0))
            {

                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                Vector3 move = new Vector3(pos.x * PanningSpeed, pos.y * PanningSpeed, 0);
                transform.Translate(-move, Space.Self);

            }
            
        }

        if (_IsRotating)
        {

            if ((Input.GetAxis("Mouse X") != 0) || (Input.GetAxis("Mouse Y") != 0))
            {

                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                transform.RotateAround(Target.position, transform.right, -pos.y * RotationSpeed);
                transform.RotateAround(Target.position, Vector3.up, pos.x * RotationSpeed);

            }
            
        }

        transform.Translate((Vector3.forward * Input.GetAxis("Mouse ScrollWheel")) * SmoothZoomSpeed);

        if (Input.GetKeyDown(KeyCode.R)) ResetPosition();

    }

    public void ResetPosition()
    {

        transform.position = StartPosition;
        transform.rotation = _StartRotation;
    }

    public void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {

            transform.Translate((Vector3.up * 0.1f));

        }

    }

}
