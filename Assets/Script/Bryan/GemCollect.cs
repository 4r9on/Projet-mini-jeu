using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollect : MonoBehaviour
{
    public string rightColors; // Bonne couleur à ramasser pour gain de score (couleur du player)
    public int score = 0; // Score du player
    public TMP_Text scoreText; // Affichage du score du player
    public GameObject interfaceText;

    public void Awake()
    {
        interfaceText.SetActive(true);
        Time.timeScale = 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            Gem gem = other.GetComponent<Gem>();

            if (gem != null && IsColorAllowed(gem.color)) 
            {
                score++; // Ajoute un point au score si c'est une gemme et si elle est de la même couleur
            }
            else
            {
                score--; // Enlève un point si le joueur ramasse la mauvaise gemme
            }
            Destroy(other.gameObject);           
            scoreText.text = "" + score;
        }
    }

    bool IsColorAllowed(string gemColor) // Vérification si la gemme est de la même couleur que le player
    {
        
            if (gemColor == rightColors)
            {
                return true;
            }
        return false;
    }
}
