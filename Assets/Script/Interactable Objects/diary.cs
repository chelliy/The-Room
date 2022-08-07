using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diary : MonoBehaviour, IInteraction
{
    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    public bool interactable { get; set; }

    public string text;

    public bool isOpenForLetters = false;

    public Image letter;

    public Transform newPos;

    public AudioClip background;

    private float playtime = 0;

    public float interaction(playerCam player)
    {
        if (isOpenForLetters)
        {
            if(playtime == 0)
            {
                this.GetComponent<AudioSource>().Play();
            }
            EventSystem.current.diaryStartTrigger();
            player.specialInteracting = true;
            player.needUnlock = false;
            letter.gameObject.SetActive(true);
            return 0f;
        }
        else
        {
            dialogue.text = text;
            dialogue.gameObject.SetActive(true);
            isOpenForLetters = true;
            this.gameObject.transform.position = newPos.position;
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
        interactable = true;
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
