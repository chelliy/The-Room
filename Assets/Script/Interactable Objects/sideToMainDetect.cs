using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideToMainDetect : MonoBehaviour
{
    public Transform door;

    private mainSideConnectedDoor mainDoor;

    public Transform bathRoomDoor;

    private mainDoor bathDoor;
    // Start is called before the first frame update
    void Start()
    {
        mainDoor = door.GetComponent<mainSideConnectedDoor>();
        bathDoor = bathRoomDoor.GetComponent<mainDoor>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.body.gameObject.CompareTag("player"))
        {
            mainDoor.mainToSide = false;
            bathDoor.mainToSide = false;
        }
    }

}
