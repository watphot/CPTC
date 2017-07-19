using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Rotation RotationScript;
    public CameraBehavior Camera;
    public Sprite_Movement1 ReturnCamera;
    public Sprite_Movement1 ReturnMachine;
    public Animator Animator;
    public bool PlayAnimation;
    public bool SliderActive;
    public bool ActiveLobby;

	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameManualModeFunction()
    {

        StartCoroutine(GameManualMode());

    }

    public IEnumerator GameManualMode()
    {

        SliderActive = !SliderActive;
        RotationScript.enabled = !RotationScript.enabled;
        Camera.enabled = !Camera.enabled;
        ReturnCamera.enabled = !ReturnCamera.enabled;
        ReturnMachine.enabled = !ReturnMachine.enabled;

        yield return new WaitForSeconds(1f);
                
        PlayAnimation = !PlayAnimation;
                
        Animator.SetBool("Loop", PlayAnimation);
        

        yield return new WaitForSeconds(0f);

    }
        
}
