using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class DistributeWaveManager : MonoBehaviour
{
    public WaveManager waveManager;

    // Start is called before the first frame update
    void Start()
    {
        foreach (WaterManager child in GetComponentsInChildren<WaterManager>()) {
            child.waveManager = waveManager;
        }
    }
}
