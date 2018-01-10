using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{

    private static Vector3 movementInput;
    public static Vector3 MovementInput { get { return movementInput; } }

    private static float mouseX;
    public static float MouseX { get { return mouseX; } }

    private static float mouseY;
    public static float MouseY { get { return mouseY; } }

    private static bool key_shift;
    public static bool Key_Shift { get { return key_shift; } }

    private static bool key_e;
    public static bool Key_E { get { return key_e; } }

    private static bool key_space;
    public static bool Key_Space { get { return key_space; } }

    private KeyCode keycode_shift = KeyCode.LeftShift;
    private KeyCode keycode_e = KeyCode.E;
    private KeyCode keycode_space = KeyCode.Space;

    private void Update()
    {
        movementInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        key_shift = Input.GetKey(keycode_shift);
        key_e = Input.GetKeyDown(keycode_e);
        key_space = Input.GetKeyDown(keycode_space);

    }
}
