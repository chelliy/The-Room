using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainDoor : MonoBehaviour,IInteraction
{
    // Start is called before the first frame update
    [SerializeField]
    private bool interactStatus;
    public bool interactable => interactStatus;

    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;



    public string textWhenWithoutKey;
    public string textWhenWithKey;

    public float delayTimeForOpeningDoor;

    public float interaction(playerCam player)
    {

        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (Inventory.hasMainDoorKey())
        {
            interactStatus = false;
            //special case, only a open door sound will be played
            dialogue.gameObject.SetActive(false);
            return delayTimeForOpeningDoor;;
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

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
