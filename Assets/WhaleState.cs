using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhaleState : MonoBehaviour
{
    public int whaleState = 3;
    public int whaleCleanThreshold = 0;
    public GameObject oil1;
    public GameObject oil2;
    public GameObject oil3;
    public HealthBar healthBar;
    public GameObject health;
    
    
    private void Start()
    {
        healthBar.SetMaxHealth(whaleState);
    }

    private void Update()
    {
        healthBar.SetHealth(whaleState);
        if (whaleState == whaleCleanThreshold)
        {
            die();
        } else if (whaleState == 3)
        {
            oil1.SetActive(false);
        } else if (whaleState == 2)
        {
            oil2.SetActive(false);
        } else if (whaleState == 1)
        {
            oil3.SetActive(false);
        }
    }

    private void die()
    {
        health.SetActive(false);
        GetComponent<DialogueTriggerWithEnd>().TriggerDialogue(() =>
        {
            SceneManager.LoadScene("Level 3");
            return 0;
        });
        gameObject.SetActive(false);
    }

}
