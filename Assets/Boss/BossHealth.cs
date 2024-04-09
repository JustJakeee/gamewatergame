using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public float bossHealth = 5;
    
    public void damage()
    {
        bossHealth -= 1;
        if (bossHealth <= 0) die();
    }

    private void die()
    {
        SceneManager.LoadScene("Level 2");
    }
}
