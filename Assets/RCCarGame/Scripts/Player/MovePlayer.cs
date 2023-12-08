using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    public float rotateSpeed;
    public bool canTurnLeft;
    public bool canTurnRight;

    [SerializeField]
    private int playerIndex = 0;


    void FixedUpdate()
    {
        //deplacement auto en fonction de la vitesse
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

    public int GetPlayerIndex()
    {
        return playerIndex;
    }
}
