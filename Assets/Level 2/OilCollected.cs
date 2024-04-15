using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OilCollected : MonoBehaviour
{
    public int oilCollected = 0;
    public GameObject whale;
    public OilGen oilGen;
    public WhaleState whaleState;
    public int changeThreshold = 30;
    public int endThreshold = 100;
    public int warningThreshold = 50;
    private DialogueTrigger dialogueTrigger;
    private bool whaleSpawned = false;
    public GameObject normalMusic;
    public GameObject bossMusic;

    private void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    private void Update()
    {
        if (whaleSpawned)
        {
            if (oilCollected >= changeThreshold)
            {
                whaleState.whaleState--;
                oilCollected = 0;
            }
        } 
        else
        {
            if (oilCollected >= endThreshold)
            {
                whale.SetActive(true);
                oilGen.enabled = false;
                normalMusic.SetActive(false);
                bossMusic.SetActive(true);
                whaleSpawned = true;
                oilCollected = 0;
            }
            else if (oilCollected >= warningThreshold)
            {
                dialogueTrigger.TriggerDialogue();
            }
        }
    }
}
