using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool hasTriggered = false;

    public void TriggerDialogue ()
    {
        if (hasTriggered) return;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        hasTriggered = true;
    }
}
