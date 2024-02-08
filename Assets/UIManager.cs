using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score = 0;

    [SerializeField]
    private TextMeshProUGUI bossFightIndicator;
    public int bossFightThreshold = 0;

    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Score: " + score.ToString();
        if (score >= bossFightThreshold) {
            bossFightIndicator.gameObject.SetActive(true);
        }
    }

    // Call this method to reset the score, e.g., when starting a new game or level
    public void ResetScore()
    {
        score = 0;
        UpdateScore(0);
    }
}
