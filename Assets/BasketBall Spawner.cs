using UnityEngine;

public class BasketBallSpawner : MonoBehaviour
{

    public GameObject BasketBallPrefab;

    public Transform BbSpawner;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(BasketBallPrefab, BbSpawner.position, BbSpawner.rotation);
    }

    public void SpawnBasketball()
    {
        Instantiate(BasketBallPrefab, BbSpawner.position, BbSpawner.rotation);
    }
}
