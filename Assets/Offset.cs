using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    public float globalOffset = 0;
    public float globalMovespeed = 1;

    void Update()
    {
        globalOffset += Time.deltaTime * globalMovespeed;
    }
}
