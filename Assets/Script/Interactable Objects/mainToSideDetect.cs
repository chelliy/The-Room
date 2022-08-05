using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainToSideDetect : MonoBehaviour
{
    public Transform door;

    private mainDoor mainDoor;
    // Start is called before the first frame update
    void Start()
    {
        mainDoor = door.GetComponent<mainDoor>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.body.gameObject.CompareTag("player"))
        {
            mainDoor.mainToSide = true;
        }
    }
}
