    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Movement1 : MonoBehaviour {

    public Transform from;
    public Transform to;
    public float speed;

    public bool speedActive;

    
    void Update()
    {

        if (speedActive)
        {

            //speed = 0.01f;

            transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.deltaTime * speed);

            transform.position = Vector3.Lerp(from.position, to.position, Time.deltaTime * speed);

        }

        else
        {

            //speed = 0f;

        }
                
    }


}

