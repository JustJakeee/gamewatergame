using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCollection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Collection collect = collision.gameObject.GetComponent<Collection>();
        Debug.Log("1");


        if (collect != null)
        {
            Debug.Log("2");
            collect.collect();
        } 
    }
}
