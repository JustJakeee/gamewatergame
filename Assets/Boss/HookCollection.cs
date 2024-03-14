using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookCollection : MonoBehaviour
{
    public BossHealth bossHealth;

    public void collect()
    {
        bossHealth.damage();
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        collect();
    }
}
