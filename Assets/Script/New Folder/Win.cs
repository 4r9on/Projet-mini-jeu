using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Win1;
    public GameObject Win2;
    public GameObject Win3;
    public GameObject Win4;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Capsule (1)")
        {
            Win1.SetActive(true);
            Debug.Log("aaaaaa");
        }
        if (collision.gameObject.name == "Capsule (2)")
        {
            Win2.SetActive(true);
        }
        if (collision.gameObject.tag == "Player3")
        {
            Win3.SetActive(true);
        }
        if (collision.gameObject.tag == "Player4")
        {
            Win4.SetActive(true);
        }
    }

    public void Quit()
    {
        Win1.SetActive(false);
        Win2.SetActive(false);
        Win3.SetActive(false);
        Win4.SetActive(false);
    }
}
