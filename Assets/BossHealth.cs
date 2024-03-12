using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Destroy(gameObject);
    }
}
