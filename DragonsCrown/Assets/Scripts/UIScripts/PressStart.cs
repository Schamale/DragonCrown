using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressStart : MonoBehaviour {

    public AudioSource pressStart;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Start"))
        {
            pressStart.Play();
        }
		
	}
}
