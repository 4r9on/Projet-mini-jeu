using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    public GameObject player3;
    public GameObject playerInGame;

    public void DeactivatePlayer()
    {
        if(playerInGame.activeSelf == true)
        {
            player3.SetActive(false);
        }
        
    }

}
