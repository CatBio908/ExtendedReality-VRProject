using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreField;

    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreField.text = " " + score.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
