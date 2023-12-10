using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{
    //Viens du tuto : https://www.youtube.com/watch?v=g_s0y5yFxYg

    [SerializeField]public float speed;
    [SerializeField] public float jump;
    [SerializeField] public float gravityValue = -9.81f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    private Vector2 movInput = Vector2.zero;
    public bool jumpIs = false;


    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(movInput.x, 0, movInput.y);
        controller.Move(move * Time.deltaTime * speed);

        if(jumpIs && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jump * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jumpIs = context.ReadValue<bool>();
        jumpIs = context.action.triggered;
    }

}
