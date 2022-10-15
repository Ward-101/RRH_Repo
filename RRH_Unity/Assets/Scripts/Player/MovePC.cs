using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePC : Move
{
    [SerializeField] private PlayerInputHandler inputHandler;

    protected override void Update()
    {
        direction = inputHandler.MovementInput;

        base.Update();
    }
}
