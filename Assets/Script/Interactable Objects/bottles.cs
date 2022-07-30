using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottles : MonoBehaviour,IInteraction
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



    public string text;

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
    void Start()
    {
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
