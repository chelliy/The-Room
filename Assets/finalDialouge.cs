using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class finalDialouge : MonoBehaviour
{
    // Start is called before the first frame update
    public bool start = false;
    public float delayTime;
    public Text text;
    public string dialouge;

    public Transform mainCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void starting()
    {
        text.gameObject.SetActive(true);
        mainCamera.gameObject.GetComponent<playerCam>().interactionTime = delayTime;
        text.text = dialouge;
        start = true;
    }
}
