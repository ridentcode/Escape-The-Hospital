﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class TextController : MonoBehaviour {
	
	public Text text; 
	
	// Use this for initialization
	void Start () {
		text.text = "Hello, my name is Daniel Anatolie";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			text.text = "Space key has been pressed";
		}
	}
}
