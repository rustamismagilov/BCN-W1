using System;
using TMPro.EditorUtilities;
using UnityEngine;

public class Slicing : MonoBehaviour
{
    private bool hasFruit;
    public Transform[] stuckFruit;
    public GameObject[] fruitObj;
    [SerializeField]
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fruit") && !hasFruit)
        { 
            Debug.Log("Fruit sliced!");
            hasFruit = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Skewer") && hasFruit == true)
        {
            Debug.Log("Slice added to skewer!");
            SkewerFruit();
            hasFruit = false;

        }
    }

   public void SkewerFruit()
    { 
        int randomFruit = UnityEngine.Random.Range(0, fruitObj.Length);
        
        for (int i = 0; i < stuckFruit.Length; i++)
        {
            Instantiate(fruitObj[randomFruit], stuckFruit[i].position, fruitObj[randomFruit].transform.rotation);
        }
        
    }
}
