using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class OilAttack : MonoBehaviour
{
    public Offset offset;
    public GameObject oil;
    public bool variance = false;
    public float range = 5f;
    public float waveSpeed = 1f;

    public float varianceAmount = 0.1f;

    private float cooldown = 2f;
    public float delay = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0f)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            Vector3 newPos = new Vector3(math.sin(offset.globalOffset * waveSpeed) * range, 0, transform.position.z);
            if (variance)
            {
                Vector2 varianceVector = UnityEngine.Random.insideUnitCircle * varianceAmount;
                newPos.x += varianceVector.x;
                newPos.z += varianceVector.y;
            }
            Instantiate(oil, newPos, Quaternion.identity);
            cooldown = delay;
        }
    }
}
