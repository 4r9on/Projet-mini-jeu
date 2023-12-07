using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GoGame : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           /* Debug.Log("aaaaaaaaaaa");
            Instantiate(enemy, transform.position, Quaternion.identity);*/
            
        }



    }

    void Spawn()
    {
        /*if ()
        {
            player.SetActive(true);
        }
        if ()
        {
            enemy1.SetActive(true);

        }
        if ()
        {
            enemy2.SetActive(true);
        }
        if ()
        {
            enemy3.SetActive(true);
        }*/
    }

}
