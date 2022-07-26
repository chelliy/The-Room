using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;
    public Transform cameraPos;
    public Transform InteractionUI;

    public float interactionDistance = 2f;

    public string interactableTag = "interactable";

    private float interactionTime = 0;

    private bool UIDisplayed = false;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        interactCheck();
    }

    private void interactCheck()
    {


        if (interactionTime > 0)
        {
            interactionTime = interactionTime - Time.deltaTime;
        }
        else
        {
            RaycastHit hit;

            Ray ray = new Ray(cameraPos.position, transform.forward);

            bool ifHit = Physics.Raycast(ray, out hit, interactionDistance);

            if (ifHit)
            {
                GameObject currentObj = hit.transform.gameObject;
                if (currentObj.CompareTag(interactableTag))
                {
                    var interactable = currentObj.GetComponent<IInteraction>();
                    //ui display
                    if (!UIDisplayed)
                    {
                        displayInteractionUI(hit.point);
                    }

                    //interact
                    if (interactable != null && Keyboard.current.eKey.wasPressedThisFrame)
                    {
                        interactionTime = interactable.interaction(this);
                    }
                }
            }
            else
            {
                if (UIDisplayed)
                {
                    stopDisplayInteractionUI();
                }
            }
        }
    }

    private void stopDisplayInteractionUI()
    {
        UIDisplayed = false;
        InteractionUI.gameObject.SetActive(false);
    }

    private void displayInteractionUI(Vector3 point)
    {
        UIDisplayed = true;
        InteractionUI.position = point;
        InteractionUI.gameObject.SetActive(true);
    }
}
