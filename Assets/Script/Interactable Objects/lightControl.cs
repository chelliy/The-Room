using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightControl : MonoBehaviour, IInteraction
{
    // Start is called before the first frame update

    [SerializeField]
    private Text dialougueUIReference;
    public Text dialogue => dialougueUIReference;


    [SerializeField]
    private float dialogueDisplayTime;
    public float displayTime => dialogueDisplayTime;

    [SerializeField]
    private bool interactionStatus = true;
    public bool interactable { get; set; }

    public string basictext = "nothing";
    public Transform[] lights;
    public Transform safeKey;

    public bool isLightOn = true;

    public float[] lightRecord;


    // Start is called before the first frame update
    void Start()
    {
        interactable = interactionStatus;
        EventSystem.current.dialougeHide += setDialogueInActive;
        lightRecord = new float[lights.Length];
        for(int i = 0; i<lights.Length; i++)
        {
            lightRecord[i] = lights[i].GetComponent<Light>().intensity;
        }
    }

    public float interaction(playerCam player)
    {
        dialogue.gameObject.SetActive(false);
        var Inventory = player.gameObject.transform.parent.gameObject.GetComponent<Inventory>();
        if (!Inventory.hasSafeKey()) {
            if (isLightOn)
            {
                safeKey.gameObject.SetActive(true);
            }
            else
            {
                safeKey.gameObject.SetActive(false);
            } 
        }
        changingLight();
        return 0;
    }

    public void setDialogueInActive()
    {
        dialogue.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void changingLight()
    {
        isLightOn = !isLightOn;
        for (int i = 0; i < lights.Length; i++)
        {
            var currentLight = lights[i].GetComponent<Light>();
            if(currentLight.intensity == 0.5f)
            {
                currentLight.intensity = lightRecord[i];
            }
            else
            {
                currentLight.intensity = 0.5f;
            }
        }
    }

}
