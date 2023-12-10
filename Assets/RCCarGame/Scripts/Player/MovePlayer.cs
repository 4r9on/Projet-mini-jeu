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
    public GameObject imgPressButton;
    public GameObject imgPressedButton;



    [Header("Variable a modifier, Player1 = 0")]
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


    public void ButtonPressed()
    {
        Debug.Log("button press");
        imgPressButton.SetActive(false);
        imgPressedButton.SetActive(true);
    }


    public int GetPlayerIndex()
    {
        return playerIndex;
    }
}
