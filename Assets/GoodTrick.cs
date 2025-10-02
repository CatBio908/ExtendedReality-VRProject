using UnityEngine;

public class GoodTrick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float SpinSpeed = 150f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(SpinSpeed * Time.deltaTime, SpinSpeed * Time.deltaTime, 0);
    }
}
