using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic; 

public class BasketBallSpawner : MonoBehaviour
{
    public static BasketBallSpawner instance; 
    public GameObject BasketBallPrefab;

    public Transform BbSpawner;

    public List<Transform> SpwnSpts;

    public List<GameObject> basketBalls;


    private void Awake()
    {
        // lasy singleton setup
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBasketball(); 

    }

    public void SpawnBasketball()
    {
        DestroyBBs();
        foreach (var Spwns in SpwnSpts)
        {
            GameObject bBall = Instantiate(BasketBallPrefab, Spwns.position, BbSpawner.rotation);
            basketBalls.Add(bBall);
        }
    }

    public void DestroyBBs()
    {
        foreach (var bBall in basketBalls)
        {
            Destroy(bBall);
        }
        basketBalls.Clear();
    }

    public void DestroyBall(GameObject deadBall)
    {
        basketBalls.Remove(deadBall);
        Destroy(deadBall);

        if (basketBalls.Count == 0)
        {
            AllBallsGone(); 
        }
    }

    public void AllBallsGone()
    {

    }

}
