using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {

    public GameObject myParticleSystem;
    public Rotation RotationScript;

    public GameObject TaponMachine;
    public GameObject TaponBolsa;

	// Use this for initialization
	void Start () {
		
	}

    public void ActiveDesinfectation()
    {

        myParticleSystem.active = !myParticleSystem.active;

    }

    public void Testing()
    {

        
        RotationScript.enabled = true;

    }

    public void Particles()
    {

        myParticleSystem.active = false;

    }

    public void Base()
    {

        TaponMachine.active = false;
        TaponBolsa.active = true;

    }

    public void Entrada()
    {

        TaponMachine.active = false;
        TaponBolsa.active = true;

    }

    public void Ciclo()
    {

        TaponMachine.active = !TaponMachine.active;
        TaponBolsa.active = !TaponBolsa.active;

    }    

}
