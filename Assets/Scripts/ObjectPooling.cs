using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    public List<GameObject> pooledObjects;
    public GameObject[] objectsToPool;
    public int poolTotal;
    public static ObjectPooling SharedInstance;
    public Transform[] spawnPoints;
    public Transform spawnLoc;

    void Awake()
    {
        SharedInstance = this;
        spawnLoc = spawnPoints[UnityEngine.Random.Range(0, 8)];
    }


    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject fruit;
        for (int i = 0; i < poolTotal; i++)
        {
            fruit = Instantiate(objectsToPool[UnityEngine.Random.Range(0, 3)], spawnLoc);
            fruit.SetActive(false);
            pooledObjects.Add(fruit);
        }
    }
}
