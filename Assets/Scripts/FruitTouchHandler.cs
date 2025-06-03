using UnityEngine;

public class FruitTouchHandler : MonoBehaviour
{
    private FruitManager fruitManager;

    void Start()
    {
        fruitManager = FindFirstObjectByType<FruitManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fruit"))
        {
            fruitManager.PlaceFruitAtNextPoint(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
