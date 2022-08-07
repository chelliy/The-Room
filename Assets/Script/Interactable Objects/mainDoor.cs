using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainDoor : MonoBehaviour
{
    // Start is called before the first frame update



    public Transform door;

    //after key
    public bool unlocked = true;

    //see if door open
    public bool doorOpen = false;

    //door open animation control
    public bool mainToSide = true;

    //door close animation control
    public bool openStatusMainToSide = true;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

}
