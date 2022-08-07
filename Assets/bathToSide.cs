using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathToSide : MonoBehaviour
{

    public Transform bathRoomDoor;

    private mainDoor bathDoor;
    // Start is called before the first frame update
    void Start()
    {
        bathDoor = bathRoomDoor.GetComponent<mainDoor>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.body.gameObject.CompareTag("player"))
        {
            bathDoor.mainToSide = true;

        }
    }
}
