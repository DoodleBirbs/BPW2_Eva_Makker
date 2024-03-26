using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrogTrigger : MonoBehaviour
{
    public GameObject Can;
    public GameObject Cam;
    public GameObject Player;
    public GameObject tbc;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("Enter");
            tbc.SetActive(true);
            WaitForSecondsRealtime(5);
            Application.Quit();
        }
    }

    private void WaitForSecondsRealtime(int v)
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggereddd");
        Can.SetActive(true);
        Cam.SetActive(true);
        Player.SetActive(false);
    }
}
