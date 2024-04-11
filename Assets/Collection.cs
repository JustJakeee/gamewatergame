using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public ScoreManager UI;

    public void collect()
    {
        if (UI != null)
        {
            UI.UpdateScore(1);
        }
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        collect();
    }

    /*private void Update()
    {
        DetectObjectWithRaycast();
    }

    public void DetectObjectWithRaycast()
    {
        if (Input.GetMouseButtonDown(0))
        {

            print("Mouse clicked");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    print(hit.collider.gameObject.name);
                    if (hit.collider.gameObject == gameObject)
                    {
                        collect();
                    }
                }
                else
                {
                    print("No object detected");
                }
            }
        }
    }*/
}
