﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject activateOnWon; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnTriggerEnter(Collider other) {

			Application.LoadLevel(0);

	}
}
