using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class otherLetterControl : MonoBehaviour
{
    public Sprite[] letters;

    private Image image;
    [SerializeField]
    public int currentLetter = 0;

    public float delayTime = 0.3f;

    void Awake()
    {
        image = this.gameObject.GetComponent<Image>();
        image.sprite = letters[currentLetter];
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
        }
    }
    public void readingSelfLetter()
    {
        currentLetter = 0;
        image.sprite = letters[currentLetter];
    }
    public void readingDoctorLetter()
    {
        currentLetter = 1;
        image.sprite = letters[currentLetter];
    }
}
