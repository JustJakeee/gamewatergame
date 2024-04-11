using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    [SerializeField]
    private Offset offset;
    [SerializeField]
    private float verticalTransform;

    private void Update()
    {
        transform.position = new Vector3(0, 0, offset.globalOffset + verticalTransform);
    }
}
