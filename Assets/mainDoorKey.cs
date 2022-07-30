using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainDoorKey : MonoBehaviour,IInteraction
{
    [SerializeField]
    private bool interactStatus;
    public bool interactable => interactStatus;

    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;



    public string text;

    public float interaction(playerCam player)
    {
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        Inventory.setMainDoorKeyTrue();
        dialogue.gameObject.SetActive(false);
        interactStatus = false;
        return displayTime;
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
