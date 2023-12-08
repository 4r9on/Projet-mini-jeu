using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public int numberOfLap = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            numberOfLap += 1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (numberOfLap >= 3)
        {
            Debug.Log("Player win");
        }
    }
}
