using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public string rightColors; // Bonne couleur � ramasser pour gain de score (couleur du player)
    ScoreManager sm;
    Score score;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            Gem gem = other.GetComponent<Gem>();

            if (gem != null && IsColorAllowed(gem.color)) 
            {
                sm.AddScore(score); // Ajoute un point au score si c'est une gemme et si elle est de la m�me couleur
            }
            Destroy(other.gameObject);
            sm.AddScore(score);
        }
    }

    bool IsColorAllowed(string gemColor) // V�rification si la gemme est de la m�me couleur que le player
    {
        
            if (gemColor == rightColors)
            {
                return true;
            }
        return false;
    }
}
