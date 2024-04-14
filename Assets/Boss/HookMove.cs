using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMove : MonoBehaviour
{
    public Offset gameOffset;
    private float localOffset;
    public Vector3 playerPositionAtSpawn;
    private float cooldown = 1;
    public Vector3 bossTransformAtSpawn;
    private Vector3 lastPos;
    private float lastDiff;
    public bool sendBack = false;

    private void Start()
    {
        localOffset = gameOffset.globalOffset;
    }

    private void Update()
    {;
        if (cooldown > 1)
        {
            GetComponent<HookCollection>().bossHealth.damage();
            Destroy(gameObject);
        }
        else if (cooldown > 0)
        {
            if (sendBack)
            {
                cooldown += Time.deltaTime;
            }
            else
            {
                cooldown -= Time.deltaTime;
            }
            Vector3 offsetVec = new Vector3(0, 0, gameOffset.globalOffset);
            Vector3 localOffsetVec = new Vector3(0, 0, localOffset);
            //transform.position = Vector3.Lerp(transform.position, playerPositionAtSpawn - offsetVec, cooldown);
            //transform.position += offsetVec;
            // make hook lerp towards player position
            transform.position = Vector3.Lerp(playerPositionAtSpawn - localOffsetVec + offsetVec, bossTransformAtSpawn - localOffsetVec + offsetVec, cooldown);
            lastPos = transform.position;
            lastDiff = transform.position.z - gameOffset.globalOffset;
        }
        else
        {
            Destroy(gameObject);
        }
    } 
}
