using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chair : MonoBehaviour, IInteraction
{


    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    public bool interactable { get; set ; }

    public string text;

    void Start()
    {
        interactable = true;
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    public float interaction(playerCam player)
    {
        dialogue.text = text;
        dialogue.gameObject.SetActive(true);
        return displayTime;
    }


    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
