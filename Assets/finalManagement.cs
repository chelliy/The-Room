using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalManagement : MonoBehaviour
{
    public Transform[] sideRooms;
    public Transform finalRoom;
    private bool timeCorrect = false;
    private bool lettersRead = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (timeCorrect && lettersRead)
        {
            finalSceneGenerate();
        }
    }

    private void finalSceneGenerate()
    {
        Debug.Log("hha");
        finalRoom.gameObject.SetActive(true);
        foreach(Transform current in sideRooms)
        {
            current.gameObject.SetActive(false);
        }
    }

    public void timeIsCorrect()
    {
        timeCorrect = true;
        Debug.Log("time");
    }

    public void lettersAreRead()
    {
        lettersRead = true;
        Debug.Log("letter");
    }
}
