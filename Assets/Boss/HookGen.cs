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

    private Vector2 boxCenter;
    [SerializeField]
    private float verticalOffset;
    [SerializeField]
    private Vector2 boxSize;

    private float cooldown = 3;
    private BossHealth health;


    // Start is called before the first frame update
    void Start()
    {
        health = gameObject.GetComponent<BossHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;

        if (cooldown > 0) return;

        boxCenter = new Vector2(0, offset.globalOffset + verticalOffset);
        GameObject newHook = Instantiate(hook, GetRandomPointInBox(), Quaternion.identity);
        newHook.GetComponent<HookCollection>().bossHealth = health;
        cooldown = 1;
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
