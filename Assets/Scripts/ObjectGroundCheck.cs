using UnityEngine;
using System.Collections;

public class ObjectGroundCheck : MonoBehaviour {

    //Range between the object and the defined ground.
    //the larger the range the earlier "is grounded".
    [SerializeField]
    private float range;

    //Ground object for this object.
    private GameObject ground;

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
