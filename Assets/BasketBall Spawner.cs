using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic; 

public class BasketBallSpawner : MonoBehaviour
{
    public static BasketBallSpawner instance; 

    public Transform BbSpawner;

    public List<GameObject> BBPrefabs;

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
        RandomBalls();

    }

    public void SpawnBasketball()
    {
        RandomBalls();
       
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

    public void RandomBalls()
    {

        DestroyBBs();
        foreach (var Spwns in SpwnSpts)
        {
            int RandomIndex = Random.Range(0, BBPrefabs.Count);

            GameObject ChosenBall = BBPrefabs[RandomIndex];

            GameObject bBall = Instantiate(ChosenBall, Spwns.position, BbSpawner.rotation);
            basketBalls.Add(bBall);
        }
        
    }

}
