using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject tbc;
    void Start()
    {
        
    }
    void Update()
    {

    }
    public void Exit()
    {
        tbc.SetActive(true);
        WaitForSecondsRealtime(5);
        Application.Quit();
    }

    private void WaitForSecondsRealtime(int v)
    {
        throw new NotImplementedException();
    }
}
