using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doctorNote : MonoBehaviour, IInteraction
{
    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    public bool interactable { get; set; }

    public string text;

    public Transform otherLetter;

    private otherLetterControl letterControl;


    public float interaction(playerCam player)
    {
        EventSystem.current.diaryStartTrigger();

        player.specialInteracting = true;
        player.needUnlock = false;

        otherLetter.gameObject.SetActive(true);

        letterControl = otherLetter.GetComponent<otherLetterControl>();
        letterControl.readingDoctorLetter();
        return 0;
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
