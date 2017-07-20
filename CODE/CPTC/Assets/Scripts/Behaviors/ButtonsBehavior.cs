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

    public Image PlayButton;
    public Sprite PlaySprite1;
    public Sprite PlaySprite2;

    public Image PauseButton;
    public Sprite PauseSprite1;
    public Sprite PauseSprite2;

    public Image SpeedButton;
    public Sprite SpeedSprite1;
    public Sprite SpeedSprite2;

    // Use this for initialization
    void Start () {

        //Time.timeScale -= 0.5f;

    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(Time.timeScale);

        if (TimeScale == true)
        {

            PlayButton.sprite = PlaySprite1;
            PauseButton.sprite = PauseSprite2;

        }
        else if (TimeScale == false)
        {

            PlayButton.sprite = PlaySprite2;
            PauseButton.sprite = PauseSprite1;

        }

        if (Speed == true)
        {

            SpeedButton.sprite = SpeedSprite1;

        }

        else if (Speed == false)
        {

            SpeedButton.sprite = SpeedSprite2;

        }

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
