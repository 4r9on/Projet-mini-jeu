using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRandom : MonoBehaviour
{
    public GameObject[] gemPrefabs; // Prefabs des gemmes � faire apparaitre
    public float spawnRate = 2f; // Vitesse � laquelle les gemmes apparaissent
    public float spawnAreaWidth = 10f; // Superficie sur laquelle les gemmes apparaissent

    void Start()
    {
        InvokeRepeating("SpawnGem", 0f, spawnRate);
    }

    void SpawnGem()
    {
        int randomGemIndex = Random.Range(0, gemPrefabs.Length); //R�cup�re un gemme al�atoire de la liste
        GameObject gemPrefab = gemPrefabs[randomGemIndex];

        // Applique de fa�on random o� va apparaitre la gemme sur une superficie en carr�
        float randomX = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2); 
        float randomZ = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2); 
        Vector3 spawnPosition = new Vector3(randomX, 7f, randomZ);

        Instantiate(gemPrefab, spawnPosition, Quaternion.identity);
    }
}
