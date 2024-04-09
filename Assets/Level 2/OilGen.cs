using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OilGen : MonoBehaviour
{
    public Offset offset;
    public GameObject oil;
    private PointGen pointGen;
    private float threshold = 50f;
    public float range;
    public float steps;
    public float spacing;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        pointGen = GetComponent<PointGen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (offset.globalOffset + 30 > threshold)
        {
            foreach (Vector3 point in pointGen.points)
            {
                for (float i = -range; i < range; i += range * 2 / steps)
                {
                    Vector3 pos = new Vector3(i, 0, offset.globalOffset + 30);
                    if (Vector3.Distance(pos, point) < distance)
                    {
                        GameObject newOil = Instantiate(oil, pos, Quaternion.identity);
                        newOil.GetComponent<OilFloat>().offset = offset;
                    }
                }
            }
            threshold += spacing;
        }
    }
}
