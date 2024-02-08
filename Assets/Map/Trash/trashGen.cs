using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class TrashGen : MonoBehaviour
{

    [SerializeField]
    private Offset offset;
    public GameObject trash;
    public float delayInSeconds;
    public float distance;
    public float horizontalVariance;
    private float cooldown = 0;

    // Update is called once per frame
    void Update()
    {
        if (cooldown < 0) {
            Vector3 trashPos = new Vector3(Random.Range(-horizontalVariance, horizontalVariance), 0, offset.globalOffset + distance);
            Instantiate(trash, trashPos, Quaternion.identity);
            cooldown = delayInSeconds;
        }

        cooldown -= Time.deltaTime;
    }
}
