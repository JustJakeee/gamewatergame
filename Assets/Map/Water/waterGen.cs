using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class waterGen : MonoBehaviour
{
    public GameObject tile;
    public float stepSize = 10;
    public int stepCount = 10000;
    public int startIndex = 0;

    private void Start()
    {
        for (int i = startIndex; i < stepCount; i++)
        {
            Instantiate(tile, new Vector3(0, 0, i * stepSize), Quaternion.identity);
        }
    }
}
