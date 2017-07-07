using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScene : MonoBehaviour {

    public GameObject StartImage;
    public GameObject FinalImage;

    public float WaitingTime;

    public string LevelToLoad;

	// Use this for initialization
	void Start ()
    {

        StartCoroutine(ActiveImages());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator ActiveImages()
    {

        StartImage.SetActive(true);

        yield return new WaitForSeconds(WaitingTime);

        StartImage.SetActive(false);
        FinalImage.SetActive(true);

        yield return new WaitForSeconds(WaitingTime);

        Application.LoadLevel(LevelToLoad);

    }
}
