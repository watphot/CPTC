using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPartycle : MonoBehaviour {

    public Animator anim;
    public Animator animBolsa;

    public void ActiveCicle()
    {

        anim.SetTrigger("Trigger");
        animBolsa.SetTrigger("TriggerB");

    }
}
