using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelOneUI : MonoBehaviour
{
    [SerializeField]
    private GameObject boss;
    public int bossFightThreshold = 0;
    [SerializeField]
    private TrashGen trashGen;
    private bool bossFightStarted = false;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
    }

    private void Update()
    {
        if (scoreManager.score >= bossFightThreshold && !bossFightStarted)
        {
            boss.SetActive(true);
            trashGen.enabled = false;
            bossFightStarted = true;
        }
    }

}
