using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private PlayerStateMachine playerStateMachine;

    private PlayerMovement playerMovement;
    private PlayerJump playerJump;

    private Rigidbody rigid;

    private ObjectGroundCheck objectGroundCheck;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        getComponents();
    }
    
    private void getComponents()
    {
        playerStateMachine = GetComponent<PlayerStateMachine>();
        playerMovement = GetComponent<PlayerMovement>();
        playerJump = GetComponent<PlayerJump>();
    
        objectGroundCheck = GetComponent<ObjectGroundCheck>();
    
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        playerInput();
    }

    private void playerInput()
    {
        //Movement
        playerMovement.Horizontal = InputManager.MovementInput.x;
        playerMovement.Vertical = InputManager.MovementInput.y;
        playerMovement.Move(rigid);
    
        //Jump
        if(objectGroundCheck.Grounded)
            if (InputManager.Key_Space)
                playerJump.Jump(rigid);
    }
}
