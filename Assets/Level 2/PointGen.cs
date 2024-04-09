using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGen : MonoBehaviour
{
    private float cooldown = 1f;
    public List<Vector3> points = new();
    public Vector2 xRange;
    public Offset offset;
    public float time = 5f;

    void Update()
    {
        if (cooldown <= 0)
        {
            Vector3 pos = new Vector3(Random.Range(xRange.x, xRange.y), 0, offset.globalOffset + 40f);
            points.Add(pos);
            cooldown = time;
            print("Point generated at " + pos);
        }
        cooldown -= Time.deltaTime;
    }
}
