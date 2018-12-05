using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _new_game : MonoBehaviour {

    public AudioSource press_start;

    public void PressNewGame()
    {
        press_start.Play();
        StartCoroutine(DoFadeOut());
        StartCoroutine(DelaySound());
    }

    IEnumerator DoFadeOut()
    {
        CanvasGroup fade = GameObject.FindGameObjectWithTag("Fade").GetComponent<CanvasGroup>();
        Debug.Log("Fading Out");
        fade.alpha = 0;
        while (fade.alpha < 1)
        {
            fade.alpha += Time.deltaTime / 3;
            yield return null;

        }
    }

    IEnumerator DelaySound()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("DemoScene");
    }
}
