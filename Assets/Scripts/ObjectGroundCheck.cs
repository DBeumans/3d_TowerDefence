using UnityEngine;
using System.Collections;

public class ObjectGroundCheck : MonoBehaviour {
    /*
     This script only returns grounded if there is a object below it. 
     */

    //Range between the object and the defined ground.
    //the larger the range the earlier "is grounded".
    [SerializeField]
    private float range;

    //boolean that turns TRUE / FALSE when grounded or not.
    private bool grounded;
    public bool Grounded
    {
        get { return grounded; }
    }
    
    private void FixedUpdate()
    {
        raycast();
    }

    private void raycast()
    {
        grounded = Physics.Raycast(this.transform.position, Vector3.down, range);
    }
}
