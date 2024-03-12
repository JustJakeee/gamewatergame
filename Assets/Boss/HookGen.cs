using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HookGen : MonoBehaviour
{

    [SerializeField]
    private GameObject hook;
    [SerializeField]
    private Offset offset;
    [SerializeField]
    private Transform playerTransform;
    private Vector3 playerPosition;

    private Vector2 boxCenter;
    [SerializeField]
    private float verticalOffset;
    [SerializeField]
    private Vector2 boxSize;

    private float cooldown = 3;
    private BossHealth health;
    private Vector3 nextHookPosition;
    private float delay = 1;


    // Start is called before the first frame update
    void Start()
    {
        health = gameObject.GetComponent<BossHealth>();
    }

    // Update is called once per frame
    void Update()
    {   
        playerPosition = playerTransform.position;
        cooldown -= Time.deltaTime;

        if (cooldown > 0) return;

        if (nextHookPosition == null) {
            nextHookPosition = GetRandomPointInBox();
        }

        boxCenter = new Vector2(0, offset.globalOffset + verticalOffset);
        GameObject newHook = Instantiate(hook, nextHookPosition, Quaternion.identity);
        newHook.GetComponent<HookCollection>().bossHealth = health;
        newHook.GetComponent<HookMove>().offset = offset;
        nextHookPosition = playerPosition;
        nextHookPosition.z += offset.globalMovespeed * delay;
        nextHookPosition.y = 0;
        cooldown = delay;
    }

    private Vector3 GetRandomPointInBox()
    {
        // Calculate the minimum and maximum coordinates of the box
        float minX = boxCenter.x - boxSize.x / 2f;
        float maxX = boxCenter.x + boxSize.x / 2f;
        float minY = boxCenter.y - boxSize.y / 2f;
        float maxY = boxCenter.y + boxSize.y / 2f;

        // Generate random X and Y coordinates within the box
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector3(randomX, 0, randomY);
    }
}
