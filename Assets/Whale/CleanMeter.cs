using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CleanMeter : MonoBehaviour
{

    private float cleanMeter = 0;
    public float maxCleanMeter = 100;
        
    public void add()
    {
        cleanMeter += 1;
        if (cleanMeter >= maxCleanMeter) win();
    }

    private void win()
    {
        Debug.Log("You win!");
    }
}
