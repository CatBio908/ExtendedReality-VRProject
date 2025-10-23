using UnityEngine;

public class PointZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int ScoreAmount = 12;
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(ScoreAmount);
        BasketBallSpawner.instance.DestroyBall(other.gameObject); 
        Destroy(other.gameObject);
    }
}
