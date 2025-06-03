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

   
    public GameObject[] fruitObj; //array of fruit prefabs
    public Transform[] spawnPoints; //array of possible spawn points for newly instantiated fruit
    //public List<GameObject> fruitPool; //object pooling
    //public int poolTotal = 4;
    //private int arrayNum;
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        InvokeRepeating(nameof(SpawnObject), spawnInterval, spawnInterval);
        
        InvokeRepeating(nameof(SpawnFruit), spawnInterval, spawnInterval);
        
        // fruitPool = new List<GameObject>();
        // GameObject fruit;
        // for (int i = 0; i < poolTotal; i++)
        // {
        //     fruit = Instantiate(fruitObj[arrayNum], spawnPoints[UnityEngine.Random.Range(0, 8)]);
        //     fruit.SetActive(false);
        //     fruitPool.Add(fruit);
        //     arrayNum++;
        // }
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
        int randomFruit = UnityEngine.Random.Range(0, fruitObj.Length);
        
        Instantiate(fruitObj[randomFruit], spawnPoints[randomSpawn].transform.position, fruitObj[randomFruit].transform.rotation);
    }
    #endregion
}
