using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilBlobMove : MonoBehaviour
{
    public Offset gameOffset;
    private float localOffset;
    private float cooldown = 1;
    public Vector3 bossTransformAtSpawn;
    public float range;
    private Vector3 targetPosition;
    public float height = 1;
    public float endOffset = 1;
    public GameObject oilClump;

    private void Start()
    {
        localOffset = gameOffset.globalOffset;
        targetPosition = new Vector3
        (
            Random.Range(-range, range),
            0,
            Random.Range(gameOffset.globalOffset - 3, gameOffset.globalOffset + 3) + 10
        );
    }

    private void Update()
    {
        ;
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
            Vector3 offsetVec = new Vector3(0, 0, gameOffset.globalOffset);
            Vector3 localOffsetVec = new Vector3(0, 0, localOffset);
            transform.position = Vector3.Lerp(targetPosition - localOffsetVec + offsetVec, bossTransformAtSpawn - localOffsetVec + offsetVec, cooldown);
            transform.position += new Vector3(0, -height * cooldown * (cooldown - endOffset), 0);
        }
        else
        {
            var newClump = Instantiate(oilClump, transform.position, Quaternion.identity);
            newClump.SetActive(true);
            Destroy(gameObject);
        }
    }
}
