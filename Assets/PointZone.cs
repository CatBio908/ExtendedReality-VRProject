using UnityEngine;

public class PointZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        FindFirstObjectByType<ScoreManager>().AddScore(11);
        Destroy(other.gameObject);
    }
}
