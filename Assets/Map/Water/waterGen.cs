using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterGen : MonoBehaviour
{
    public GameObject tile;
    public WaveManager waveManager;
    public Offset offset;
    public float verticalOffset;
    public float stepSize = 10f;
    private float step = 0f;
    public Vector2 bounds;
    public bool sceneTwo = false;

    private void Update()
    {
        while (offset.globalOffset + bounds.y > (step + verticalOffset) * stepSize) {
            SpawnWater(new Vector3(0,0, step *  stepSize)); 
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
    
    private void SpawnWater(Vector3 position)
    {
        GameObject newWater = Instantiate(tile, position, Quaternion.identity);
        DistributeWaveManager distributeWaveManager = newWater.GetComponent<DistributeWaveManager>();
        distributeWaveManager.waveManager = waveManager;
    }
}
