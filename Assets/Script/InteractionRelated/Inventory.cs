using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool mainDoor = false;
    
    private bool safeKey = false;

    private bool battery = false;

    private bool screwdriver = false;

    private bool flashLight = false;

    public void setMainDoorKeyTrue()
    {
        mainDoor = true;
    }

    public void setFlashLightTrue()
    {
        flashLight = true;
    }
    public void setSafeKeyToTrue()
    {
        safeKey = true;
    }
    public void setBattery()
    {
        battery = true;
    }
    public void setScrewdriver()
    {
        screwdriver = true;
    }

    public bool hasMainDoorKey()
    {
        return mainDoor;
    }
    public bool hasSafeKey()
    {
        return safeKey;
    }

    public bool hasBattery()
    {
        return battery;
    }
    public bool hasScrewdriver()
    {
        return screwdriver;
    }
    public bool hasFlashLight()
    {
        return flashLight;
    }
}
