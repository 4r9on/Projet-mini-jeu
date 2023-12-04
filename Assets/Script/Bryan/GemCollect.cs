using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public string[] allowedColors;  // Tableau des couleurs que le joueur peut collecter

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            Gem gem = other.GetComponent<Gem>();
            if (gem != null && IsColorAllowed(gem.color))
            {
                // Le joueur a collect� la gemme correcte
                Destroy(other.gameObject);
            }
        }
    }

    bool IsColorAllowed(string gemColor)
    {
        foreach (string allowedColor in allowedColors)
        {
            if (gemColor == allowedColor)
            {
                return true;
            }
        }
        return false;
    }
}
