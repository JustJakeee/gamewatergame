using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkthing : MonoBehaviour
{
    public GameObject obj;
    public Animator thing;
    public string boolName = "IsAlive";

    void Update()
    {
        thing.SetBool(boolName, obj.activeSelf);
    }
}
