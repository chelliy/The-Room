using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainSideConnectedDoor : MonoBehaviour, IInteraction
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

    //after key
    public bool unlocked = false;

    //see if door open
    public bool doorOpen = false;

    //door open animation control
    public bool mainToSide = true;

    //door close animation control
    public bool openStatusMainToSide = true;

    private Animator doorAnimator;

    public Transform bruckWall;


    // Start is called before the first frame update
    void Start()
    {
        interactable = interactionStatus;
        EventSystem.current.dialougeHide += setDialogueInActive;
        doorAnimator = door.GetComponent<Animator>();
    }

    public float interaction(playerCam player)
    {
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (Inventory.hasMainDoorKey())
        {
            bruckWall.gameObject.SetActive(false);
            //special case, only a open door sound will be played
            dialogue.gameObject.SetActive(false);
            interactable = false;
            new WaitForSeconds(delayTimeForOpeningDoor);
            unlocked = true;
            doorOpen = true;
            doorAnimator.Play("door open");

            return 0;
        }
        else
        {
            dialogue.text = textWhenWithoutKey;

            dialogue.gameObject.SetActive(true);
            return displayTime;
        }

    }

    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool timePause(float delayTime)
    {
        var newTime = delayTime - Time.deltaTime;
        if (newTime > 0)
        {
            return timePause(newTime);
        }
        else
        {
            return false;
        }
    }

}
