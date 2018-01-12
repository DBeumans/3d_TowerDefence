using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private int jumpPower = 5;

    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        calculateJump();
    }

    private void calculateJump()
    {
        if (!InputManager.Key_Space)
            return;
        // add force so the player will jump
        rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
