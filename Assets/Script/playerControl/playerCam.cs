using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform flashLight;
    private Light lightSourceFL;
    public float FLIntensity;

    public Transform orientation;
    public Transform cameraPos;
    public Transform cameraPosWhenSquat;
    public Transform InteractionUI;

    public Transform currentCameraPos;

    public float interactionDistance = 2f;

    public string interactableTag = "interactable";

    private float interactionTime = 0;

    private bool UIDisplayed = false;
    private bool dialogueDisplayed = false;

    private RaycastHit previousHit;
    private bool preHit;

    private bool squat = false;
    private bool isCursorLocked = false;

    float xRotation;
    float yRotation;

    public bool specialInteracting = false;

    public bool needUnlock = true;

    private bool isFLOn = false;
    private bool hasFL = false;

    private Inventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        currentCameraPos = cameraPos;
        EventSystem.current.clockSettingStop += specialInteractingToFalse;
        EventSystem.current.diaryStop += specialInteractingToFalse;
        playerInventory = this.transform.parent.gameObject.GetComponent<Inventory>();
        lightSourceFL = flashLight.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFL)
        {
            if (playerInventory.hasFlashLight())
            {
                hasFL = true;
            }
        }
        if (!specialInteracting)
        {
            if (!isCursorLocked)
            {
                cursorLock();
            }
            //get mouse input
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -60f, 60f);
            //camera
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);
            //FL
            flashLight.rotation = Quaternion.Euler(xRotation, yRotation, 0);

            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                if (squat)
                {
                    currentCameraPos = cameraPos;
                }
                else
                {
                    currentCameraPos = cameraPosWhenSquat;
                }
                squat = !squat;
            }
            flashLight.position= currentCameraPos.position;

            if (hasFL)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (isFLOn)
                    {
                        lightSourceFL.intensity = 0;
                        isFLOn = !isFLOn;
                    }
                    else
                    {
                        lightSourceFL.intensity = FLIntensity;
                        isFLOn = !isFLOn;
                    }
                }
            }
            interactCheck();
        }
        else
        {
            if (isCursorLocked && needUnlock)
            {
                cursorUnlock();
            }
        }
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

            Ray ray = new Ray(currentCameraPos.position, transform.forward);

            bool ifHit = Physics.Raycast(ray, out hit, interactionDistance);

            if (ifHit)
            {
                //check if player see an interactable object
                GameObject currentObj = hit.transform.gameObject;
                if (currentObj.CompareTag(interactableTag))
                {
                    //bool adjustPos = false;
                    ////assign
                    //if(preHit == false)
                    //{
                    //    preHit = true;
                    //    previousHit = hit;
                    //}
                    //else
                    //{
                    //    adjustPos = !previousHit.transform.gameObject.Equals(currentObj);
                    //}

                    var interactable = currentObj.GetComponent<IInteraction>();
                    Debug.Log(currentObj.name);
                    if (interactable.interactable)
                    {
                        if (currentObj.GetComponent<MeshRenderer>())
                        {
                            displayInteractionUI(currentObj.GetComponent<MeshRenderer>().bounds.center);
                        }else if (currentObj.GetComponent<SpriteRenderer>())
                        {
                            displayInteractionUI(currentObj.GetComponent<SpriteRenderer>().bounds.center);
                        }
                        //ui display
                        //if (!UIDisplayed)
                        //{
                        //    displayInteractionUI(currentObj.GetComponent<MeshRenderer>().bounds.center);
                        //}
                        //else//checking for possible situation when multiple nteractable objects are close to each other
                        //{
                        //    if (adjustPos)
                        //    {
                        //        displayInteractionUI(currentObj.GetComponent<MeshRenderer>().bounds.center);
                        //    }
                        //}

                        //interact
                        if (Keyboard.current.eKey.wasPressedThisFrame)
                        {
                            interactionTime = interactable.interaction(this);
                            dialogueDisplayed = true;
                            stopDisplayInteractionUI();
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

    public void cursorLock()
    {
        isCursorLocked = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void cursorUnlock()
    {
        isCursorLocked = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void specialInteractingToFalse()
    {
        specialInteracting = false;
        cursorLock();
    }
}
