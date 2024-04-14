using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tempBossSpawn : MonoBehaviour
{
    public GameObject boss;
    public float timer = .3f;
    private DialogueTriggerWithEnd dialogueTrigger;

    private void Start()
    {
        dialogueTrigger = GetComponent<DialogueTriggerWithEnd>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 1000000f;
        }
    }

    private void spawn()
    {
        Func<int> endBehavior = () =>
        {
            boss.SetActive(true);
            return 0;
        };

        print(endBehavior);

        GetComponent<DialogueTriggerWithEnd>().TriggerDialogue(endBehavior);
    }
}

