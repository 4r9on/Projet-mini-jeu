using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("toucher");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

            Debug.Log("Mort");
        }
    }

}
