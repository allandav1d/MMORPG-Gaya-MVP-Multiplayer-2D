﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrlCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(GameObject.Find("Player").transform.position.x, GameObject.Find("Player").transform.position.y, transform.position.z);
	}
}
