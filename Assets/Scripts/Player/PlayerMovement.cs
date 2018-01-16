using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;

    private float currentSpeed;
    public float CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }

    private Vector3 horizontalMovement;
    private Vector3 verticalMovement;

    private Vector3 direction;

    private float horizontal;
    public float Horizontal
    {
        get { return horizontal; }
        set { horizontal = value; }
    }

    private float vertical;
    public float Vertical
    {
        get { return vertical; }
        set { vertical = value; }
    }


    private void Start()
    {
        currentSpeed = movementSpeed;    
    }

    private void Update()
    {
        Vector3 h_movement = transform.forward * vertical;
        Vector3 v_movement = transform.right * horizontal;

        horizontalMovement = h_movement.normalized;
        verticalMovement = v_movement.normalized;
    }

    public void Move(Rigidbody rb)
    {
        calculateMovement(rb);
    }

    private void calculateMovement(Rigidbody rigid)
    {
        direction = (horizontalMovement + verticalMovement) * movementSpeed;
        rigid.MovePosition(rigid.position + direction * Time.fixedDeltaTime);
    }
}