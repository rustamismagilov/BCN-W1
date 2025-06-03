using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{
    
    #region Obstacle scripting
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float spawnInterval = 5f;

    [SerializeField] private float xPos;

    [SerializeField] private float yPos;
    #endregion
   
    public GameObject[] fruitsArray; //array of fruit prefabs
    public Transform[] spawnPoints; //array of possible spawn points for newly instantiated fruit
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), spawnInterval, spawnInterval);
        
        InvokeRepeating(nameof(SpawnFruit), spawnInterval, spawnInterval);
    }

    #region spawn obstacles
    void SpawnObject()
    {
        float randomX = UnityEngine.Random.Range(-xPos, xPos);
        float randomY = UnityEngine.Random.Range(-yPos, yPos);

        Vector2 randomPosition = new Vector2(randomX, randomY);

        Instantiate(objectPrefab, randomPosition, Quaternion.identity);
    }

    void SpawnFruit()
    {
        int randomSpawn = UnityEngine.Random.Range(0, spawnPoints.Length);
        int randomFruit = UnityEngine.Random.Range(0, fruitsArray.Length);
        
        Instantiate(fruitsArray[randomFruit], spawnPoints[randomSpawn].transform.position, fruitsArray[randomFruit].transform.rotation);
    }
    #endregion
}
