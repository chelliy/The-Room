using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;
    public event Action timeReset;
    // Start is called before the first frame update

    private void Awake()
    {
        current = this;
    }

    public void TimeResetTrigger()
    {
        if (timeReset != null)
        {
            timeReset();
        }
    }
}
