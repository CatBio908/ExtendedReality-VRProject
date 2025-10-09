using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic; 

public class BasketBallSpawner : MonoBehaviour
{

    public GameObject BasketBallPrefab;

    public Transform BbSpawner;

    private List<GameObject> basketBalls;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject bBall = Instantiate(BasketBallPrefab, BbSpawner.position, BbSpawner.rotation);
        basketBalls.Add(bBall);

    }

    public void SpawnBasketball()
    {
        DestroyBBs();
        GameObject bBall = Instantiate(BasketBallPrefab, BbSpawner.position, BbSpawner.rotation);
        basketBalls.Add(bBall);
    }

    void DestroyBBs()
    {
        foreach (var bBall in basketBalls)
        {
            Destroy(bBall);
        }
        basketBalls.Clear();
    } 

}
