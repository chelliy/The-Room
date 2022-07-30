using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainDoorAnimation : MonoBehaviour
{

    public Transform Door;

    public Animator myDoor;

    private mainDoor mainDoor;

    void Start()
    {
        mainDoor = Door.GetComponent<mainDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (mainDoor)
        {
            if (other.CompareTag("player"))
            {
                if (!mainDoor.interactable)
                {
                    myDoor.Play("door open");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (mainDoor)
        {
            if (other.CompareTag("player"))
            {
                if (!mainDoor.interactable)
                {
                    myDoor.Play("door close");
                }
            }
        }
    }
}
