using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFllow : MonoBehaviour
{
    public Transform mainCamera;

    private playerCam cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = mainCamera.gameObject.GetComponent<playerCam>();
        if (cameraPosition)
        {
            transform.position = cameraPosition.currentCameraPos.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPosition.currentCameraPos.position;
    }
}
