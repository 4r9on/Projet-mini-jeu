using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject window;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    public void first()
    {
        window.SetActive(false);
    }

    public void second()
    {
        window.SetActive(false);
        player3.SetActive(true);
        camera2.SetActive(true);
        camera1.SetActive(false);

    }

    public void third()
    {
        window.SetActive(false);
        player3.SetActive(true);
        player4.SetActive(true);
        camera3.SetActive(true);
        camera1.SetActive(false);

    }
}
