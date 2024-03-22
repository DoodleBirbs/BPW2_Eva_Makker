using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightScript : MonoBehaviour
{
    public GameObject TheSun;
    public Material Mat1;

    void Start()
    {
        Debug.Log("script Active Night");
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("Night");
            TheSun.transform.rotation = Quaternion.Euler(160, -4, 0);
            RenderSettings.skybox = Mat1;
    }
}

