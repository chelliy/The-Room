using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upperDrawer : MonoBehaviour,IInteraction
{

    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    public bool interactable { get; set; }

    public bool isOpen = false;

    public string text;

    private Animator animator;

    void Start()
    {
        animator = this.GetComponent<Animator>();
        interactable = true;
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    public float interaction(playerCam player)
    {
        if (isOpen)
        {
            animator.Play("close upper drawer");
            isOpen = !isOpen;
        }
        else
        {
            animator.Play("open upper drawer");
            isOpen = !isOpen;
        }
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
