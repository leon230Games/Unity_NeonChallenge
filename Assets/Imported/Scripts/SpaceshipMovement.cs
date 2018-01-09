using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

    public float speed = 10f;
    Vector3 moveVector;

	// Use this for initialization
	void Start () {
        moveVector = Vector3.forward;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveVector * Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "Forward1")
        {
            moveVector = Vector3.down;
        }
    }
}
