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
    private bool dialogueDisplayed = false;

    private RaycastHit previousHit;
    private bool preHit;


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
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        interactCheck();
    }

    private void interactCheck()
    {


        if (interactionTime > 0)
        {
            if (UIDisplayed)
            {
                stopDisplayInteractionUI();
            }
            interactionTime = interactionTime - Time.deltaTime;
        }
        else
        {
            //hide dialogue UI
            if (dialogueDisplayed)
            {
                dialogueDisplayed = false;
                EventSystem.current.dialougeHideTrigger();
            }

            //check if player see an object
            RaycastHit hit;

            Ray ray = new Ray(cameraPos.position, transform.forward);

            bool ifHit = Physics.Raycast(ray, out hit, interactionDistance);

            if (ifHit)
            {
                //check if player see an interactable object
                GameObject currentObj = hit.transform.gameObject;
                if (currentObj.CompareTag(interactableTag))
                {
                    bool adjustPos = false;
                    //assign
                    if(preHit == false)
                    {
                        preHit = true;
                        previousHit = hit;
                    }
                    else
                    {
                        adjustPos = !previousHit.transform.gameObject.Equals(currentObj);
                    }

                    var interactable = currentObj.GetComponent<IInteraction>();
                    
                    //ui display
                    if (!UIDisplayed)
                    {
                        displayInteractionUI(currentObj.GetComponent<MeshRenderer>().bounds.center);
                    }
                    else//checking for possible situation when multiple nteractable objects are close to each other
                    {
                        if (adjustPos)
                        {
                            displayInteractionUI(currentObj.GetComponent<MeshRenderer>().bounds.center);
                        }
                    }

                    //interact
                    if (interactable != null && Keyboard.current.eKey.wasPressedThisFrame)
                    {
                        interactionTime = interactable.interaction(this);
                        dialogueDisplayed = true;
                        stopDisplayInteractionUI();
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
            else
            {
                //disable previous shown UI
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
