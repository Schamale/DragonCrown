using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicFader : MonoBehaviour {

    public CanvasGroup start_gradiant;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float pingPong = Mathf.PingPong(Time.time * 0.5f, 0.9f);
        start_gradiant.alpha = (pingPong);
		
	}
}
