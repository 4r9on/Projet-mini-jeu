using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Liste des objets joueurs
    public List<GemCollect> playersScore = new List<GemCollect>();

    void Start()
    {
        int highestScore = FindHighestScore();
    }

    int FindHighestScore()
    {
        int highestScore = 0;

        // Parcourir tous les joueurs pour trouver le score le plus élevé
        foreach (GemCollect player in playersScore)
        {
            // Vérifier si le joueur a un score plus élevé que le score actuel
            if (player.score > highestScore)
            {
                highestScore = player.score;
            }
        }

        return highestScore;
    }
}
