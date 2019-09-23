using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    private CharacterController Controller;
    private Vector3 position;
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
        
        if (Controller.isGrounded)
        {
            position.y = 0;
        }

        Controller.Move(position * Time.deltaTime);
    }
}
