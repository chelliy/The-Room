using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainDoor : MonoBehaviour,IInteraction
{
    // Start is called before the first frame update

    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    [SerializeField]
    private bool interactionStatus = true;
    public bool interactable { get; set; }

    public string textWhenWithoutKey;
    public string textWhenWithKey;

    public float delayTimeForOpeningDoor;

    public Transform door;

    private bool unlocked = false;

    public bool doorOpen = false;

    private Animator doorAnimation;


    // Start is called before the first frame update
    void Start()
    {
        doorAnimation = door.gameObject.GetComponent<Animator>();
        interactable = interactionStatus;
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    public float interaction(playerCam player)
    {
        if (unlocked)
        {
            if (doorOpen)
            {
                doorOpen = !doorOpen;
                doorAnimation.Play("door close", 0, 0.0f);
            }
            else
            {
                doorOpen = !doorOpen;
                doorAnimation.Play("door open", 0, 0.0f);
            }
            return 0;
        }
        else { 
            var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
            if (Inventory.hasMainDoorKey())
            {
                //special case, only a open door sound will be played
                unlocked = true;
                dialogue.gameObject.SetActive(false);
                return delayTimeForOpeningDoor;
            }
            else
            {
                dialogue.text = textWhenWithoutKey;

                dialogue.gameObject.SetActive(true);
                return displayTime;
            }
        }
    }


    public void setInteractableToTrue()
    {
        interactable = true;
    }
    public void setInteractableToFalse()
    {
        interactable = false;
    }


    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
