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

    public void interactiableTrue()
    {
        if (mainDoor != null)
        {
            mainDoor.setInteractableToTrue();
        }
    }
    public void interactiableFalse()
    {
        if (mainDoor != null)
        {
            mainDoor.setInteractableToFalse();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
