using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboG : MonoBehaviour
{

    public float Speed;
    public float jumpForce;

    private bool isGrounded;
    //private bool isSecondJumpAvailable;
    
    
    void Update()
    {
        //Move
        //if (Input.GetKey(KeyCode.W))
        //{
        //transform.position += new Vector3(0f, 0f, Speed * Time.deltaTime);
        //  transform.position += Vector3.forward * Speed * Time.deltaTime; 
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * Speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //   transform.position += Vector3.left * Speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * Speed * Time.deltaTime;
        //  }

        //Automove
        transform.position += new Vector3(1f, 0f, 0f) * Speed * Time.deltaTime;

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            transform.position += Vector3.up * Speed * Time.deltaTime;

            if (!isGrounded)
            {
               
            }

        }
        //Gravity
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Physics.gravity = new Vector3(0f, 9.81f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Physics.gravity = new Vector3(0f, -9.81f, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter");
        isGrounded = true;
        //isSecondJumpAvailable = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CollisionExit");
        isGrounded = false;
        
    }
}
