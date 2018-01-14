using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    //amount of force downwards.
    private float forcePower;

    //direction of the forcepower
    private Vector3 direction;

    //rigidbody componenent reference
    private Rigidbody rigid;

    private void Start()
    {
        forcePower = 10f;
        direction = new Vector3();

        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;

        if (rigid == null)
            Debug.LogError("ERROR: " + this.gameObject.name + "does not have an rigidbody component.");
    }

    private void FixedUpdate()
    {
        if (rigid == null)
            return;
        direction = new Vector3(0, -forcePower, 0);

        rigid.AddForce(direction);
    }

}
