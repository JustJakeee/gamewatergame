using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookCollection : MonoBehaviour
{
    public BossHealth bossHealth;

    public void collect()
    {
        GetComponent<HookMove>().sendBack = true;
    }

    private void OnMouseDown()
    {
        collect();
    }
}
