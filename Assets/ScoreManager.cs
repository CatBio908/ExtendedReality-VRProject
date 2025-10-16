using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;


    public TextMeshProUGUI scoreField;

    private int score = 0;

    private void Awake()
    {
        // lazy singleton 
        instance = this;
    }

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
