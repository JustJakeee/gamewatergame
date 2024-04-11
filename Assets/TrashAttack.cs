using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashAttack : MonoBehaviour
{
    public GameObject trash;
    public float spacing = 1f;
    public float range = 5f;
    public float cooldown = 2f;
    public float delay = 2f;
    public float amount = 4f;
    private float angleOffset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        angleOffset = Random.Range(0, 360);
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
            var center = new Vector3(Random.Range(-range, range), 0, transform.position.z);
            for (var i = 0f; i < 360f; i += 360f / amount)
            {
                var newPos = center + Quaternion.Euler(0, 0, i + angleOffset) * Vector3.forward;
                Instantiate(trash, newPos, Quaternion.identity);
            }
            cooldown = delay;
        }
    }
}
