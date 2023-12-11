using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject Win1;
    public GameObject Win2;
    public GameObject Win3;
    public GameObject Win4;

    public TextMeshProUGUI winner;

    public Leaderboard leaderboard;

    public string SceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            SceneManager.LoadScene(SceneName);

            winner.text = "Player 1";
           // leaderboard.score = 5;

            
        }
        if (collision.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene(SceneName);


            winner.text = "Player 2";
            //leaderboard.score = 5;


        }
        if (collision.gameObject.tag == "Player3")
        {
            SceneManager.LoadScene(SceneName);


            winner.text = "Player 3";
            //leaderboard.score = 5;

        }
        if (collision.gameObject.tag == "Player4")
        {
            SceneManager.LoadScene(SceneName);


            winner.text = "Player 4";
            //leaderboard.score = 5;

        }
    }
}
