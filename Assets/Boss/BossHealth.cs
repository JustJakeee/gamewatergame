using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public float bossHealth = 5;
    public PlayParticles particles;
    
    public void damage()
    {
        bossHealth -= 1;
        particles.play();
        if (bossHealth <= 0) die();
    }

    private void die()
    {
        GetComponent<DialogueTriggerWithEnd>().TriggerDialogue(() =>
        {
            SceneManager.LoadScene("Level 2");
            return 0;
        });
        gameObject.SetActive(false);
    }
}
