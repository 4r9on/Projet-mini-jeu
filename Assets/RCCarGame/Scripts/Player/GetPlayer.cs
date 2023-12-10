using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer : MonoBehaviour
{

    public GameObject imgPressButton;
    public GameObject imgPressedButton;
    public int nbOfPlayer = 0;

    public void ButtonPressed()
    {
        Debug.Log("button press");
        imgPressButton.SetActive(false);
        imgPressedButton.SetActive(true);
        nbOfPlayer += 1;
    }

}
