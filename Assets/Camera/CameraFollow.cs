using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Offset offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.z = offset.globalOffset;
        transform.position = newPos;
    }
}
