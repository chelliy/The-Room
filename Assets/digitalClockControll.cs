using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class digitalClockControll : MonoBehaviour
{
    // Start is called before the first frame update
    DateTime DateFetcher;
    public Text hour, minute;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RealWorldTime();
    }

    void RealWorldTime()
    {
        DateFetcher = DateTime.Now;
        hour.text = DateFetcher.Hour.ToString();
        minute.text = DateFetcher.Minute.ToString();
    }
}
