using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private int jumpPower = 10;

    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
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
        rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
