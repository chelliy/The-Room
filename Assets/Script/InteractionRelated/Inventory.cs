using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool key1 = false;
    
    private bool key2 = false;

    public void setKey1ToTrue()
    {
        key1 = true;
    }
    public void setKey2ToTrue()
    {
        key2 = true;
    }

    public bool hasKey1()
    {
        return key1;
    }
    public bool hasKey2()
    {
        return key2;
    }
}
