using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Score: " + score.ToString();
    }

    // Call this method to reset the score, e.g., when starting a new game or level
    public void ResetScore()
    {
        score = 0;
        UpdateScore(0);
    }
}
