﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

    public GameObject myParticleSystem;
    public Rotation RotationScript;

	// Use this for initialization
	void Start () {
		
	}

    public void ActiveDesinfectation()
    {

        myParticleSystem.active = !myParticleSystem.active;

    }

    public void Testing()
    {

        myParticleSystem.active = false;
        RotationScript.enabled = true;

    }

}
