using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public ScoreManager UI;

    public void collect()
    {
        UI.UpdateScore(1);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        collect();
    }
}
