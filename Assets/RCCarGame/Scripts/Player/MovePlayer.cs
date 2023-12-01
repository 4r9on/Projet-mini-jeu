using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    public Rigidbody body;
    public float rotateSpeed;
    private bool canTurnLeft;
    private bool canTurnRight;
    [SerializeField]
    private InputActionReference actionLeft;
    [SerializeField]
    private InputActionReference actionRight;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = transform.up * speed;
        if (canTurnLeft)
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        else if (canTurnRight)
        {
            transform.Rotate(- Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        else
        {
            return;
        }  
    }

    public void OnMoveRight(InputAction.CallbackContext value)
    {

        if (value.started)
        {
            Debug.Log("started");
            canTurnRight = true;
        }
        if (value.performed)
        {
            Debug.Log("perform");
            canTurnRight = true;
        }
        if (value.canceled)

        {
            Debug.Log("cancel");
            canTurnRight = false;
        }
    }
    public void OnMoveLeft(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Debug.Log("started");
            canTurnLeft = true;
        }
        if (value.performed)
        {
            Debug.Log("perform");
            canTurnLeft = true;
        }
        if (value.canceled)

        {
            Debug.Log("cancel");
            canTurnLeft = false;
        }
    }
}
