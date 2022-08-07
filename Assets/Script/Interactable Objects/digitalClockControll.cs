using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class digitalClockControll : MonoBehaviour, IInteraction
{
    // Start is called before the first frame update
    DateTime DateFetcher;
    public Text hour, minute;

    public TextMeshProUGUI UIhourTenth, UIhourSingal, UIminuteTenth, UIminuteSingal;

    public Transform finalSceneSystem;
    private finalManagement final;



    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;

    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    [SerializeField]
    private bool interactionStatus = true;
    public bool interactable { get; set; }

    public string textWhenNoBatteryNoScrewdriver;

    public string textWhenNoBatteryHasScrewdriver;

    public string textWhenHasBatteryNoScrewdriver;

    public string textWhenHasBatteryHasScrewdriver;

    public bool isClockWorkig = false;

    public Transform clockSettingUI;


    private float currentHour = 0f;
    private float currentMinute = 0f;

    public float targetHour = 10f;
    public float targetMinute = 30f;

    void Start()
    {
        final = finalSceneSystem.gameObject.GetComponent<finalManagement>();
        interactable = interactionStatus;
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
        if (!isClockWorkig)
        {
            var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
            if (Inventory.hasBattery()&&Inventory.hasScrewdriver())
            {
                dialogue.text = textWhenHasBatteryHasScrewdriver;
                isClockWorkig = !isClockWorkig;
                hour.transform.parent.gameObject.SetActive(true);
            }
            else if(Inventory.hasBattery())
            {
                dialogue.text = textWhenHasBatteryNoScrewdriver;
            }else if (Inventory.hasScrewdriver())
            {
                dialogue.text = textWhenNoBatteryHasScrewdriver;
            }
            else
            {
                dialogue.text = textWhenNoBatteryNoScrewdriver;
            }
            dialogue.gameObject.SetActive(true);
            return displayTime;
        }
        else
        {
            player.specialInteracting = true;
            player.needUnlock = true;
            clockSettingUI.gameObject.SetActive(true);
            EventSystem.current.clockSettingStartTrigger();
            return -1;
        }
    }

    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }


    public void clockSetComplete()
    {
        currentHour = int.Parse(UIhourTenth.text)*10 + int.Parse(UIhourSingal.text);
        currentMinute = int.Parse(UIminuteTenth.text) * 10 + int.Parse(UIminuteSingal.text); ;
        clockSettingUI.gameObject.SetActive(false);
        this.hour.text = currentHour.ToString();
        this.minute.text = currentMinute.ToString();
        Debug.Log(currentHour);
        Debug.Log(currentMinute);

        if(currentHour == targetHour && currentMinute == targetMinute)
        {
            final.timeIsCorrect();
        }
        EventSystem.current.clockSettingStopTrigger();
        
    }
}
