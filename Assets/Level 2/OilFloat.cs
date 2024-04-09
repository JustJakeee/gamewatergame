using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilFloat : MonoBehaviour
{
    public WaveManager waveManager;
    public Offset offset;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, waveManager.GetWaveHeight(transform.position), transform.position.z);
        if (offset.globalOffset - 30 > transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
