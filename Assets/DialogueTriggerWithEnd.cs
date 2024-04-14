using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerWithEnd : MonoBehaviour
{
    public Dialogue dialogue;
    private bool hasTriggered = false;

    public void TriggerDialogue(Func<int> endBehavior)
    {
        if (hasTriggered) return;
        var dialogueManager = FindObjectOfType<DialogueManager>();
        dialogueManager.endBehavior = endBehavior;
        dialogueManager.StartDialogue(dialogue);
        hasTriggered = true;
    }
}
