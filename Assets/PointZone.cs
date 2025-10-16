using UnityEngine;

public class PointZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(11);
        BasketBallSpawner.instance.DestroyBall(other.gameObject); 
        Destroy(other.gameObject);
    }
}
