using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhaleState : MonoBehaviour
{
    public int whaleState = 3;
    public int whaleCleanThreshold = 0;

    private void Update()
    {
        if (whaleState == whaleCleanThreshold)
        {
            die();
        }
    }

    private void die()
    {
        GetComponent<DialogueTriggerWithEnd>().TriggerDialogue(() =>
        {
            SceneManager.LoadScene("Level 3");
            return 0;
        });
        gameObject.SetActive(false);
    }

}
