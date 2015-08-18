﻿using UnityEngine;
using System.Collections;

public class clickbutton : MonoBehaviour {

	bool dispmenu = false;
	private Color ourColor;
	public GameObject camert;
	public GameObject targ = null;
	float timemit = 0.0f;

	// Use this for initialization
	void Start () {
		camert = GameObject.Find ("Main Camera");
	
	}
	
	// Update is called once per frame
	void Update () {
		timemit += Time.deltaTime;	
	}


	//Brighten icon in and make sound
	void OnMouseEnter()
	{

		ourColor = GetComponent<Renderer>().material.GetColor("_Color");

		GetComponent<AudioSource> ().Play ();

		if(ourColor.a >= 0.659f)
		{
			ourColor.a = 1.0f;
			GetComponent<Renderer>().material.SetColor ("_Color", ourColor);
		}
	}
	
	//Fade icon
	void OnMouseExit()
	{
		ourColor = GetComponent<Renderer>().material.GetColor("_Color");
		
		if(ourColor.a >= 0.67f)
		{
			ourColor.a = 0.66f;
			GetComponent<Renderer>().material.SetColor ("_Color", ourColor);
		}
	}
}
