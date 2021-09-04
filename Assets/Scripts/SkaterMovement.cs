using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterMovement : MonoBehaviour
{
    //public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //var movement = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0,  movement, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.001f){
            
            rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }
    }
}
