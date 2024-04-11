using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilCollect : MonoBehaviour
{
    public OilCollected count;

    public void collect()
    {
        if (count != null)
        {
            count.oilCollected++;
        }
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            print("Mouse clicked");
            collect();
        }
    }
}
