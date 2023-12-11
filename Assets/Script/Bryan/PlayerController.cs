using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 7.0f;
    [SerializeField]

    private float playerRotation = 7.0f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    Vector2 movementInput = Vector2.zero;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        if (movementInput != Vector2.zero)
        {
            float targetAngle = Mathf.Atan2(playerVelocity.x, playerVelocity.z) * Mathf.Rad2Deg;

            float angle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, playerRotation * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);
        }

        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y);
        controller.Move(move * Time.deltaTime * playerSpeed);


        controller.Move(playerVelocity * Time.deltaTime);
    }
}
