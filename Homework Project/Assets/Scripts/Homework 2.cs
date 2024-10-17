using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Homework2 : MonoBehaviour
{
    public float moveSpeed;
    public float originalSpeed = 4f;
    public float sprintSpeed = 8f;
    public float originalJumpPower = 6f;
    public float jumpPower;
    public float powerGainedPerFrame;
    float maximumJumpPower = 12f;
    Vector3 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  //movement code
        bool upPressed = Input.GetKey(KeyCode.UpArrow);
        if(upPressed)
        {
            transform.position = transform.position + movementDirection.normalized + Vector3.forward * moveSpeed * Time.deltaTime;
        }

        bool downPressed = Input.GetKey(KeyCode.DownArrow);
        if (downPressed)
        {
            transform.position = transform.position + movementDirection.normalized + Vector3.back * moveSpeed * Time.deltaTime;
        }

        bool rightPressed = Input.GetKey(KeyCode.RightArrow);
        if (rightPressed)
        {
            transform.position = transform.position + movementDirection.normalized + Vector3.right * moveSpeed * Time.deltaTime;
        }

        bool leftPressed = Input.GetKey(KeyCode.LeftArrow);
        if(leftPressed)
        {
            transform.position = transform.position + movementDirection.normalized + Vector3.left * moveSpeed * Time.deltaTime;
        }

        //jump code
        bool jumpPowerPressed = Input.GetKeyDown(KeyCode.Space);
        if(jumpPowerPressed)
        {
            Rigidbody myRb = GetComponent<Rigidbody>();
            myRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        //charged jump code
        bool chargedJump = Input.GetKey(KeyCode.LeftControl);
        if(chargedJump)
        {
            powerGainedPerFrame = powerGainedPerFrame + 0.01f;
            jumpPower = originalJumpPower + (originalJumpPower * powerGainedPerFrame);
            
        }
        else
        {
            jumpPower = originalJumpPower;
            powerGainedPerFrame = 0f;
        }

        //sprint code
        bool sprintKey = Input.GetKey(KeyCode.LeftShift);
        if(sprintKey)
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = originalSpeed;
        }
        
        //max jump power code
       if(jumpPower >= maximumJumpPower)
        {
            jumpPower = maximumJumpPower;
        }


        //rotate code
        bool rotateLeft = Input.GetKey(KeyCode.Q);
        if (rotateLeft)
        {
            transform.Rotate(Vector3.down);
        }

        bool rotateRight = Input.GetKey(KeyCode.E);
        if (rotateRight)
        {
            transform.Rotate(Vector3.up);
        }

    }
}
