using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class digitalClockControll : MonoBehaviour, IInteraction
{
    // Start is called before the first frame update
    DateTime DateFetcher;
    public Text hour, minute;

    [SerializeField] 
    private bool interactStatus;
    public bool interactable => interactStatus;


    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;

    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;


    public string textWhenNoBattery;

    public string textWhenHasBattery;


    void Start()
    {
        EventSystem.current.dialougeHide += setDialogueInActive;
    }

    //void RealWorldTime()
    //{
    //    DateFetcher = DateTime.Now;
    //    hour.text = DateFetcher.Hour.ToString();
    //    minute.text = DateFetcher.Minute.ToString();
    //}

    public float interaction(playerCam player)
    {
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (Inventory.hasBattery())
        {
            dialogue.text = textWhenHasBattery;
        }
        else
        {
            dialogue.text = textWhenNoBattery;
        }
        dialogue.gameObject.SetActive(true);
        return displayTime;
    }

    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }
}
