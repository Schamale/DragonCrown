using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToWhiteMenu : MonoBehaviour {

    void Start()
    {
        CanvasGroup fade = GetComponent<CanvasGroup>();
        fade.alpha = 1;
        StartCoroutine(DoFadein());
    }
    //Fade in 
    IEnumerator DoFadein()
    {
        yield return new WaitForSeconds(0.3f);
        Debug.Log("Fading in.");
        CanvasGroup fade = GetComponent<CanvasGroup>();
        fade.interactable = false;
        fade.alpha = 1;
        while (fade.alpha > 0)
        {
            fade.alpha -= Time.deltaTime;
            yield return null;
        }

    }

    void Update()
    {
        
    }
}
