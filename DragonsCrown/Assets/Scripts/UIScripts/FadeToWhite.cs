using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToWhite : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DoFadeIn());
	}
	//Fade in 
    IEnumerator DoFadeIn()
    {
        Debug.Log("Fading In.");
        CanvasGroup fade = GetComponent<CanvasGroup>();
        fade.interactable = false;
        fade.alpha = 1;
        while (fade.alpha > 0)
        {
            fade.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        
        yield return null;
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Start"))
        {
            StartCoroutine(DoFadeOut());
        }

    }

    IEnumerator DoFadeOut()
    {
        StopCoroutine(DoFadeIn());
        CanvasGroup fade = GetComponent<CanvasGroup>();
        Debug.Log("Fading Out");
        fade.alpha = 0;
        while (fade.alpha < 1)
        {
            fade.alpha += Time.deltaTime;
            if (fade.alpha == 1)
            {
                LoadLevel("MainMenu");
                yield return null;
            }
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("Loading Level: " + name);
        SceneManager.LoadScene("MainMenu");
    }
}
