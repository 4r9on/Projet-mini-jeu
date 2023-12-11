using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public bool OnJump = true;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K) && OnJump)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            OnJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnJump = true;
    }
}
