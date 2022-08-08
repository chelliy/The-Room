using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashLight : MonoBehaviour, IInteraction
{
    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    public bool interactable { get; set; }

    public string text;

    public float interaction(playerCam player)
    {
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (Inventory)
        {
            Inventory.setFlashLightTrue();
        }
        dialogue.text = text;
        dialogue.gameObject.SetActive(true);
        interactable = false;
        this.gameObject.SetActive(false);
        return displayTime;
    }


    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        interactable = true;
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
