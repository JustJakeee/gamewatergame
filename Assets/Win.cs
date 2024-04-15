using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public float threshold = 100;
    private float timer = 0;
    public GameObject bar;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth((int)threshold);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= threshold)
        {
            SceneManager.LoadScene("win");
        }
        healthBar.SetHealth((int)threshold - (int)timer);
    }
}
