using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterGen : MonoBehaviour
{
    public GameObject tile;
    public WaveManager waveManager;
    public Offset offset;
    public float stepSize = 10f;
    private float step = 0f;
    public Vector2 bounds;

    private void Update()
    {
        while (offset.globalOffset + bounds.y > step * stepSize) {
            spawnWater(new Vector3(0,0, step *  stepSize));
            step += 1;
        }

        GameObject[] tiles = GameObject.FindGameObjectsWithTag("WaterTiles");

        foreach (GameObject currentTile in tiles)
        {
            if (currentTile.transform.position.z < offset.globalOffset + bounds.x) {
                Destroy(currentTile);
            }
        }
    }
    
    private void spawnWater(Vector3 position)
    {
        GameObject newWater = Instantiate(tile, position, Quaternion.identity);
        newWater.GetComponent<DistributeWaveManager>().waveManager = waveManager;
    }
}
