using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Rotation RotationScript;
    public CameraBehavior Camera;
    public Sprite_Movement1 ReturnCamera;
    public Sprite_Movement1 ReturnMachine;
    public Animator Animator;
    public Animator AnimatorBolsa;
    public Animator AnimatorCam;
	public Animator AnimatorBox;
    public bool PlayAnimation;
    public bool PlayAnimationBolsa;
    public bool PlayAnimationCam;
	public bool PlayAnimationBox;
    public bool SliderActive;
    public bool ActiveLobby;

    public Image EnterButton;
    public Sprite EnterSprite1;
    public Sprite EnterSprite2;
    public bool EnterButtonBool;

    // Use this for initialization
    void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {

        if (EnterButtonBool == true) EnterButton.sprite = EnterSprite1;
        else if (EnterButtonBool == false) EnterButton.sprite = EnterSprite2;

    }

    public void GameManualModeFunction()
    {

        StartCoroutine(GameManualMode());

    }

    public IEnumerator GameManualMode()
    {

        SliderActive = !SliderActive;
        EnterButtonBool = !EnterButtonBool;
        
        RotationScript.enabled = false;
        Camera.enabled = !Camera.enabled;
        ReturnCamera.enabled = !ReturnCamera.enabled;
        ReturnMachine.enabled = !ReturnMachine.enabled;
        PlayAnimationCam = !PlayAnimationCam;
        AnimatorCam.SetBool("LoopC", PlayAnimationCam);
		PlayAnimationBox = !PlayAnimationBox;
		AnimatorBox.SetBool("LoopBX", PlayAnimationBox);

        yield return new WaitForSeconds(1f);
                
        PlayAnimation = !PlayAnimation;
        PlayAnimationBolsa = !PlayAnimationBolsa;        
                
        Animator.SetBool("Loop", PlayAnimation);
        AnimatorBolsa.SetBool("LoopB", PlayAnimationBolsa);        

        yield return new WaitForSeconds(0f);

    }
        
}
