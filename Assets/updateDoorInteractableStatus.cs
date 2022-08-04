using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateDoorInteractableStatus : MonoBehaviour
{
    // Start is called before the first frame update
    private mainDoor mainDoor;
    void Start()
    {
        mainDoor = this.GetComponentInChildren<mainDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
