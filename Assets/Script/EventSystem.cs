using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;
    public event Action timeReset;
    public event Action dialougeHide;
    public event Action clockSettingStop;
    public event Action clockSettingStart;
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
    public void dialougeHideTrigger()
    {
        if (dialougeHide != null)
        {
            dialougeHide();
        }
    }
    public void clockSettingStopTrigger()
    {
        if (clockSettingStop != null)
        {
            clockSettingStop();
        }
    }
    public void clockSettingStartTrigger()
    {
        if (clockSettingStart != null)
        {
            clockSettingStart();
        }
    }
}
