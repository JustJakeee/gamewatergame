using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OilBlobGen : MonoBehaviour
{

    [SerializeField]
    private GameObject oilBlob;
    [SerializeField]
    private Offset offset;
    public GameObject blobSpawn;

    private float verticalOffset;

    private float cooldown = 3;
    private CleanMeter cleanMeter;
    public float delay = 1;
    public PlayParticles playParticles;


    // Start is called before the first frame update
    void Start()
    {
        cleanMeter = gameObject.GetComponent<CleanMeter>();
    }

    // Update is called once per frame
    void Update()
    {   
        cooldown -= Time.deltaTime;

        if (cooldown > 0) return;

        GameObject newHook = Instantiate(oilBlob, blobSpawn.transform.position, Quaternion.identity);
        playParticles.play();
        newHook.SetActive(true);
        newHook.GetComponent<OilBlobMove>().bossTransformAtSpawn = blobSpawn.transform.position;
        cooldown = delay;
    }
}
