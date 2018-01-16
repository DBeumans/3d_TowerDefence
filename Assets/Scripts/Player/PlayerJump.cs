using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private int jumpPower = 10;

    public void Jump(Rigidbody rb)
    {
        calculateJump(rb);
    }

    private void calculateJump(Rigidbody rigid)
    {
        // add force so the player will jump
        rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
