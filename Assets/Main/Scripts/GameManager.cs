using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    private int score;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int addedScore)
    {
        score += addedScore;
        scoreText.text = $"Score: {score}";
    }

    public void UpdateLives(int livesRemoved)
    {
        lives -= livesRemoved;
        livesText.text = $"Lives: {lives}";
    }
}
