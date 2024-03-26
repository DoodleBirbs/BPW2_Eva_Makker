using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NightScript : MonoBehaviour
{
    public GameObject TheSun;
    public MeshRenderer Frog1;
    public MeshRenderer Frog2;
    public Material Mat1;
    public Animator WaterColor;

    void Start()
    {
        Debug.Log("script Active Night");
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Frog1.enabled = false;
        Frog2.enabled = true;
        WaterColor.enabled = true; 
        Debug.Log("Night");
            TheSun.transform.rotation = Quaternion.Euler(160, -4, 0);
            RenderSettings.skybox = Mat1;
    }
}

