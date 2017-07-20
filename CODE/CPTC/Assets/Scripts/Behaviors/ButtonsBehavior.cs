using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsBehavior : MonoBehaviour {

    [SerializeField]
    private bool TimeScale;
    [SerializeField]
    private bool Speed;
    public Rotation rotation;
    public Animator Animator;
    public Animator AnimatorCam;

    // Use this for initialization
    void Start () {

        //Time.timeScale -= 0.5f;

    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(Time.timeScale);

		
	}

    public void WebApplication()
    {

        Application.OpenURL("https://cartobol.es/project/ecofill-ht1-drum-aseptica/");

    }

    public void NegativeTimeScaleTime()
    {

        TimeScale = !TimeScale;

        if (TimeScale)
        {

            Time.timeScale = 0;

        }

        else if (!TimeScale && !Speed)
        {

            Time.timeScale = 0.5f;

        }

        else if (!TimeScale && Speed)
        {

            Time.timeScale = 1f;

        }

    }

    public void NegativeSpeed()
    {

        //rotation.enabled = !rotation.enabled;

        Speed = !Speed;

        if (Speed && !TimeScale)
        {

            Time.timeScale = 1f;

        }

        else if (!Speed && !TimeScale)
        {

            Time.timeScale = 0.5f;

        }

    }

    public void Replay()
    {

        Animator.SetTrigger("Replay");
        AnimatorCam.SetTrigger("ReplayC");
        
    }

}
