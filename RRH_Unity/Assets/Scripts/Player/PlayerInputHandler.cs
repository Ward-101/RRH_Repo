using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 MovementInput { get; private set; }
    public bool MeleeInput { get; private set; }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }

    public void OnMeleeInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (context.started)
            {
                MeleeInput = true;
            }
        }
    }

    public void UseMeleeInput() => MeleeInput = false;
}
