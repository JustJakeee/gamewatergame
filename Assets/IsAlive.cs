using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAlive : MonoBehaviour
{
    public GameObject obj;
    public Animator thing;
    public string boolName = "IsAlive";

    void update()
    {
        thing.SetBool(boolName, obj.activeSelf);
    }
}
