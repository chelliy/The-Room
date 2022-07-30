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

        if (mainDoor != null)
        {
            if (other.CompareTag("player"))
            {
                if (mainDoor.doorOpen)
                {
                    myDoor.Play("door close");
                    mainDoor.doorOpen = !mainDoor.doorOpen;
                }
            }
        }
    }
}
