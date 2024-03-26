using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayScript : MonoBehaviour
{
    public GameObject TheSun;
    public Material Mat2;
    public Animator WaterColor;
    void Start()
    {
        WaterColor.enabled = false;
        Debug.Log("script Active");
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.activeSelf)
        {
            WaterColor.enabled = false;
            Debug.Log("Night");
            TheSun.transform.rotation = Quaternion.Euler(50, 30, 0);
            RenderSettings.skybox = Mat2;
        }
    }
}
