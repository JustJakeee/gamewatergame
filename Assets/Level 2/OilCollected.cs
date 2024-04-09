using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OilCollected : MonoBehaviour
{
    public int oilCollected = 0;
    
    public int endThreshold = 100;
    private DialogueTrigger dialogueTrigger;

    private void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    private void Update()
    {
        if (oilCollected >= endThreshold)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
