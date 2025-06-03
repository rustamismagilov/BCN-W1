using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    private int currentSpawnIndex = 0;

    public void PlaceFruitAtNextPoint(GameObject originalFruit)
    {
        if (currentSpawnIndex >= spawnPoints.Length) return;

        Transform spawnPoint = spawnPoints[currentSpawnIndex];
        currentSpawnIndex++;

        GameObject clone = Instantiate(originalFruit, spawnPoint.position, Quaternion.identity);
        clone.SetActive(true);
    }
}
