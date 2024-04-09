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
    public int warningThreshold = 0;
    private bool warned = false;
    [SerializeField]
    private TrashGen trashGen;
    private bool bossFightStarted = false;
    private ScoreManager scoreManager;
    private DialogueTrigger dialogueTrigger;

    private void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    private void Update()
    {
        if (scoreManager.score >= warningThreshold && !warned)
        {
            warned = true;
            dialogueTrigger.TriggerDialogue();
        }

        if (scoreManager.score >= bossFightThreshold && !bossFightStarted)
        {
            boss.SetActive(true);
            trashGen.enabled = false;
            bossFightStarted = true;
        }
    }

}
