using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterControl : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform finalSceneSystem;
    private finalManagement final;

    public Sprite[] letters;

    private Image image;
    [SerializeField]
    public int currentLetter= 0;

    public bool[] counters;

    private float delayTime = 0.3f;

    private bool done = false;
    void Start()
    {
        final = finalSceneSystem.gameObject.GetComponent<finalManagement>();
        image = this.gameObject.GetComponent<Image>();
        image.sprite = letters[currentLetter];
        counters = new bool[letters.Length];

    }

    // Update is called once per frame
    void Update()
    {
        if (delayTime > 0)
        {
            delayTime = delayTime - Time.deltaTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EventSystem.current.diaryStopTrigger();
                delayTime = 0.3f;
                this.gameObject.SetActive(false);

            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentLetter > 0)
                {
                    currentLetter--;
                }
                image.sprite = letters[currentLetter];
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentLetter < letters.Length - 1)
                {
                    currentLetter++; 
                }
                image.sprite = letters[currentLetter];
            }
            counters[currentLetter] = true;
        }
        if (!done)
        {
            readCheck();
        }
    }

    private void readCheck()
    {
        foreach(bool current in counters)
        {
            if (!current)
                return;
        }
        final.lettersAreRead();
        done = true;
    }
}
