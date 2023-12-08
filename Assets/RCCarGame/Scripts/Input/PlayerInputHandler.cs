using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;


public class PlayerInputHandler : MonoBehaviour
{

    private PlayerInput playerInput;
    private MovePlayer movePlayer;



    // Start is called before the first frame update
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<MovePlayer>();
        movePlayer = movers.FirstOrDefault(m => m.GetPlayerIndex() == playerInput.playerIndex);
    }

    public void OnMoveRight(InputAction.CallbackContext value)
    {
        if (movePlayer != null)
        {
            if (value.started)
            {
                movePlayer.canTurnRight = true;
            }
            if (value.performed)
            {
                movePlayer.canTurnRight = true;
            }
            if (value.canceled)
            {
                movePlayer.canTurnRight = false;
            }
        }
    }
    public void OnMoveLeft(InputAction.CallbackContext value)
    {
        if (movePlayer != null)
        {
            if (value.started)
            {
                movePlayer.canTurnLeft = true;
            }
            if (value.performed)
            {
                movePlayer.canTurnLeft = true;
            }
            if (value.canceled)
            {
                movePlayer.canTurnLeft = false;
            }
        }
    }
}
