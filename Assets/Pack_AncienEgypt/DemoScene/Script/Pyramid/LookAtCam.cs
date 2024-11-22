﻿using UnityEngine;
using System.Collections;

public class LookAtCam : MonoBehaviour {


	private Transform cam;
	// Use this for initialization
	void Start () {

		//cam = GameObject.Find ("Minifig Character").transform;
		cam =  GameObject.FindGameObjectsWithTag("Player")[0].transform;



	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(transform.position + cam.rotation * Vector3.forward,
		                 cam.rotation * Vector3.up);
	}
}
