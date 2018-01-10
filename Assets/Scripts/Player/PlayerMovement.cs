using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;

    float currentSpeed;

    private Rigidbody rigid;

    private Vector3 horizontalMovement;
    private Vector3 verticalMovement;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();

        currentSpeed = movementSpeed;

        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        float horizontal = InputManager.MovementInput.x;
        float vertical = InputManager.MovementInput.y;

        Vector3 h_movement = transform.forward * vertical;
        Vector3 v_movement = transform.right * horizontal;

        horizontalMovement = h_movement.normalized;
        verticalMovement = v_movement.normalized;

    }

    private void FixedUpdate()
    {
        calculateMovement_horizontal();
        calculateMovment_vertical();
    }

    private void calculateMovement_horizontal()
    {
        horizontalMovement = horizontalMovement * movementSpeed * Time.deltaTime;
        rigid.MovePosition(rigid.position + horizontalMovement);
    }

    private void calculateMovment_vertical()
    {
        verticalMovement = verticalMovement * movementSpeed * Time.deltaTime;
        rigid.MovePosition(rigid.position + verticalMovement);
    }
}
