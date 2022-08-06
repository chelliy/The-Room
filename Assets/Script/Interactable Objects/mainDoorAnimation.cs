using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainDoorAnimation : MonoBehaviour
{

    public Transform Door;

    private Animator myDoor;

    private mainDoor mainDoor;

    void Start()
    {
        mainDoor = Door.gameObject.GetComponent<mainDoor>();
        myDoor = Door.parent.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (mainDoor != null && other.CompareTag("player") && mainDoor.unlocked && mainDoor.doorOpen)
        {
            if (mainDoor.openStatusMainToSide)
            {
                myDoor.Play("door close");
                mainDoor.doorOpen = !mainDoor.doorOpen;
            }
            else
            {
                myDoor.Play("door close from side room");
                mainDoor.doorOpen = !mainDoor.doorOpen;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (mainDoor != null && other.CompareTag("player") && mainDoor.unlocked && !mainDoor.doorOpen)
        {
            if (mainDoor.mainToSide)
            {
                myDoor.Play("door open");
                mainDoor.openStatusMainToSide = true;
                mainDoor.doorOpen = !mainDoor.doorOpen;
            }
            else
            {
                myDoor.Play("door open from side room");
                mainDoor.openStatusMainToSide = false;
                mainDoor.doorOpen = !mainDoor.doorOpen;
            }
        }
    }
            
}
