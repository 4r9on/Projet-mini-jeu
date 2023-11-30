using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvManette : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float AxisX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * AxisX * Time.deltaTime);

        float AxisY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * AxisY * Time.deltaTime);
    }
}
