using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class safe : MonoBehaviour, IInteraction
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


    public Transform safeDoor;


    private Animator safeDoorAnimator;

    public Transform safeLock,locks;



    // Start is called before the first frame update
    void Start()
    {
        interactable = interactionStatus;
        EventSystem.current.dialougeHide += setDialogueInActive;
        safeDoorAnimator = safeDoor.GetComponent<Animator>();
    }

    public float interaction(playerCam player)
    {
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (Inventory.hasSafeKey())
        {
            //special case, only a open door sound will be played
            safeLock.gameObject.SetActive(false);
            locks.gameObject.SetActive(false);
            dialogue.gameObject.SetActive(false);
            interactable = false;
            safeDoorAnimator.Play("safe door open");
            interactable = false;

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

}
