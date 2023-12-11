using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Liste des objets joueurs
    public List<GemCollect> players = new List<GemCollect>();
    public TMP_Text textWin;

    void Start()
    {
        // Appeler la fonction pour trouver le score le plus élevé
        int highestScore = FindHighestScore();
        textWin.text = "Le joueur à gagné avec " + highestScore + " points";

    }

    int FindHighestScore()
    {
        // Si la liste est vide, retourner 0
        if (players.Count == 0)
        {
            return 0;
        }

        // Initialiser la variable pour stocker le score le plus élevé
        int highestScore = players[0].score;

        // Parcourir tous les joueurs pour trouver le score le plus élevé
        for (int i = 1; i < players.Count; i++)
        {
            // Vérifier si le joueur a un score plus élevé que le score actuel
            if (players[i].score > highestScore)
            {
                highestScore = players[i].score;
            }
        }

        // Retourner le score le plus élevé
        return highestScore;
    }
}
