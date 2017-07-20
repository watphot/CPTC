using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsBehavior : MonoBehaviour {

    [SerializeField]
    private bool TimeScale;
    [SerializeField]
    private bool Speed;
    public Rotation rotation;
    public Animator Animator;
    public Animator AnimatorCam;
	public Animator AnimatorBox;
    public Animator AnimatorBolsa;
        
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

    public void Play()
    {

        TimeScale = true;

        if (TimeScale && Speed)
        {

            Time.timeScale = 1f;

        }

        else if (TimeScale && !Speed)
        {

            Time.timeScale = 0.5f;

        }

    }

    public void Pause()
    {

        TimeScale = false;

        if (!TimeScale && Speed)
        {

            Time.timeScale = 0f;

        }

        else if (!TimeScale && !Speed)
        {

            Time.timeScale = 0f;

        }

    }

    public void NegativeSpeed()
    {

        Speed = !Speed;

        if (Speed)
        {

            Time.timeScale = 1f;

        }

        else if (!Speed)
        {

            Time.timeScale = 0.5f;

        }

    }

    public void Replay()
    {

        Animator.SetTrigger("Replay");
        AnimatorCam.SetTrigger("ReplayC");
		AnimatorBox.SetTrigger("ReplayBX");
        AnimatorBolsa.SetTrigger("ReplayB");
        
    }

    public void ChangeAutomaticButton()
    {



    }

    public void ChangePauseButton()
    {



    }

    public void ChangePlayButton()
    {



    }

}
