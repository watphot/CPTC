using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTitle : MonoBehaviour {

    public string startScene;

    //public string levelScene;

    public GameObject activeAlphaToStart;

    public void Start()
    {

        Debug.Log(Time.timeScale);

    }

    public void StartScene()
    {

        StartCoroutine(startOutStartScene());
                
    }

    public void QuitApplication()
    {

        StartCoroutine(startOutQuitApplication());

    }

    public IEnumerator startOutStartScene()
    {

        activeAlphaToStart.SetActive(true);

        yield return new WaitForSeconds(2f);

        Application.LoadLevel(startScene);

    }

    public IEnumerator startOutQuitApplication()
    {

        activeAlphaToStart.SetActive(true);

        yield return new WaitForSeconds(2f);

        Application.Quit();

    }

}
