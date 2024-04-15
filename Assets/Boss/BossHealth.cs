using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public int bossHealth = 5;
    public PlayParticles particles;
    public HealthBar healthBar;
    public GameObject healthBarPrefab;
    
    public void damage()
    {
        bossHealth -= 1;
        particles.play();
        if (bossHealth <= 3) die();
    }

    private void die()
    {
        GetComponent<DialogueTriggerWithEnd>().TriggerDialogue(() =>
        {
            SceneManager.LoadScene("Level 2");
            return 0;
        });
        gameObject.SetActive(false);
        healthBarPrefab.SetActive(false);

    }

    private void Update()
    {
        healthBar.SetHealth(bossHealth);
    }
}
