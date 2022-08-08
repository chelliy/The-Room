using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalLetterControl : MonoBehaviour
{
    public float delayTime = 0.3f;
    public Transform finalDialouge;

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (delayTime > 0)
        {
            delayTime = delayTime - Time.deltaTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EventSystem.current.diaryStopTrigger();
                delayTime = 0.3f;
                this.gameObject.SetActive(false);
                finalDialouge.GetComponent<finalDialouge>().starting();
            }
        }
    }
}
