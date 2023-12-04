using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRandom : MonoBehaviour
{
    public GameObject[] gemPrefabs;
    public float spawnRate = 2f;
    public float spawnAreaWidth = 10f; // Largeur de la zone de spawn

    void Start()
    {
        InvokeRepeating("SpawnGem", 0f, spawnRate);
    }

    void SpawnGem()
    {
        int randomGemIndex = Random.Range(0, gemPrefabs.Length);
        GameObject gemPrefab = gemPrefabs[randomGemIndex];

        float randomX = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2); // Ajustement pour la zone carrée
        Vector3 spawnPosition = new Vector3(randomX, 7f, 0f);

        Instantiate(gemPrefab, spawnPosition, Quaternion.identity);
    }
}
