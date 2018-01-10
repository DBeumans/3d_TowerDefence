using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float jumpPower = 5;



    private void FixedUpdate()
    {
        calculateJump();
    }

    private void calculateJump()
    {
        if (!InputManager.Key_Space)
            return;
    }
}
