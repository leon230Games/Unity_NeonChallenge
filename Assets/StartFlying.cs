﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlying : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            transform.parent.GetComponent<Animator>().enabled = true;
        }
    }
}
