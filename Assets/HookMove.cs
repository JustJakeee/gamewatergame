using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMove : MonoBehaviour
{
    public Offset offset;
    private Vector3 localOffset;

    private void Start()
    {
        localOffset = transform.position - new Vector3(0, 0, offset.globalOffset);
    }

    private void Update()
    {
        transform.position = localOffset + new Vector3(0, 0, offset.globalOffset);
    }
}
