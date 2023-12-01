using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouvManette : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;

    float AxisX, AxisY;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * AxisX * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * AxisY * Time.deltaTime);
    }

    public void  OnHorizontal(InputValue val)
    {
        AxisX = val.Get<float>();
    }

    public void OnVerticall(InputValue val)
    {
        AxisY  = val.Get<float>();
    }
}
