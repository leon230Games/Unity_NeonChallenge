using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float speed = 10f;
    public Transform girl;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = girl.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "StartShooting")
        {
            animator.SetBool("Shoot", true);
            speed = 0f;
        }
        
    }
}