using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // player stagemachine, states: idle, moving, jumping
    // this class contains references to scripts such as playerMovement.
    // This class checks for input

    private PlayerStateMachine playerStateMachine;

    private PlayerMovement playerMovement;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        getComponents();
    }

    private void getComponents()
    {
        playerStateMachine = GetComponent<PlayerStateMachine>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void FixedUpdate()
    {
        playerInput();
    }
    private void playerInput()
    {
        playerMovement.Horizontal = InputManager.MovementInput.x;
        playerMovement.Vertical = InputManager.MovementInput.y;
    }
}
