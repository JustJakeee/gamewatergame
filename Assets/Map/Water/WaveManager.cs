using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    private Vector3[] values;

    private Offset offset;
    public float speed = 1f;
    public float steepness = 1f;
    public float amp = 1f;
    public float length = 1f;

    private void Start()
    {
        offset = GetComponent<Offset>();
    }

    public float GetWaveHeight(Vector3 position)
    {
        float waveHeight = 0f;
        foreach (Vector3 value in values)
        {
            waveHeight += GerstnerWave(position, offset.globalOffset * speed, value.x * length, value.y * amp, value.z * (Mathf.PI / 180), steepness).y;
        }
        return waveHeight;
    }

    public static Vector3 GerstnerWave(Vector3 position, float time, float waveLength, float amplitude, float direction, float steepness)
    {
        float k = 2 * Mathf.PI / waveLength;
        float w = Mathf.Sqrt(9.8f * k); // Angular frequency
        float q = k * steepness;
        float x0 = position.x;
        float z0 = position.z;

        float f = k * (x0 * Mathf.Cos(direction) + z0 * Mathf.Sin(direction)) - w * time;
        float qf = q * f;

        float x = x0 + amplitude * qf * Mathf.Cos(f);
        float y = amplitude * Mathf.Sin(qf);
        float z = z0 + amplitude * qf * Mathf.Sin(f);
    
        return new Vector3(x, y, z);
    }
}
