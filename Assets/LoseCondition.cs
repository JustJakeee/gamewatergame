using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public Offset offset;
    public int count = 0;
    public int threshold = 30;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // loop over objects with tag "RequiredCollect" and load scene "MainMenu" if their z position is atleast 10 less than the global offset
        GameObject[] collectibles = GameObject.FindGameObjectsWithTag("RequiredCollect");
        foreach (GameObject collectible in collectibles)
        {
            if (collectible.transform.position.z < offset.globalOffset - 10)
            {
                count++;
                Destroy(collectible);
            }
        }

        if (count >= threshold)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lose Screen");
        }
    }
}
