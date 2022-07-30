using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool mainDoor = false;
    
    private bool key2 = false;

    private bool battery = false;

    public void setMainDoorKeyTrue()
    {
        mainDoor = true;
    }
    public void setKey2ToTrue()
    {
        key2 = true;
    }
    public void setBattery()
    {
        battery = true;
    }

    public bool hasMainDoorKey()
    {
        return mainDoor;
    }
    public bool hasKey2()
    {
        return key2;
    }

    internal bool hasBattery()
    {
        return battery;
    }
}
