using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _back_to_start : MonoBehaviour {

    public void ToStart()
    {
        Debug.Log("Going to 1st Scene");
        SceneManager.LoadScene("StartScreen");
    }
}
