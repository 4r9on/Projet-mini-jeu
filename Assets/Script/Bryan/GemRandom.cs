using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRandom : MonoBehaviour
{
    public GameObject[] gemPrefabs;
    public float spawnRate = 2f;
    public float spawnAreaWidth = 10f;

    void Start()
    {
        InvokeRepeating("SpawnGem", 0f, spawnRate);
    }

    void SpawnGem()
    {
        int randomGemIndex = Random.Range(0, gemPrefabs.Length);
        GameObject gemPrefab = gemPrefabs[randomGemIndex];

        float randomX = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2);
        float randomZ = Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2); 
        Vector3 spawnPosition = new Vector3(randomX, 7f, randomZ);

        Instantiate(gemPrefab, spawnPosition, Quaternion.identity);
    }
}
