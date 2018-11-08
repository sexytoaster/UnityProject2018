using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private const float LANE_DISTANCE = 2.0f;


    private CharacterController controller;
    private float jumpForce = 8.0f;
    private float gravity = 12.0f;
    private float verticalVelocity;
    private float speed = 7.0f;
    private int desiredLane = 1; //0 = left, 1 = middle, 2 = right

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        speed = speed + .01f;
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLane(false);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveLane(true);
        }

        //calculate where we should be
        Vector3 targetPosition = transform.position.z * Vector3.forward;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * LANE_DISTANCE;
        }
        else if (desiredLane == 2)
            targetPosition += Vector3.right * LANE_DISTANCE;

        //calculate move delta
        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * speed;

        if(controller.isGrounded) //if grounded
        {
            verticalVelocity = -0.1f;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //jump
                verticalVelocity = jumpForce;
            }

        }
        else
        {
            verticalVelocity -= (gravity * Time.deltaTime);
            //fast Fall
            if(Input.GetKeyDown(KeyCode.S))
            {
                verticalVelocity = -jumpForce;
            }
        }

        moveVector.y = verticalVelocity;
        moveVector.z = speed;


        controller.Move(moveVector * Time.deltaTime);
    }

    private void MoveLane(bool goingRight)
    {
        if (!goingRight)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }
        else
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Death")
        {
            hit.transform.SendMessage("Death", SendMessageOptions.DontRequireReceiver);
        }
    }
}
