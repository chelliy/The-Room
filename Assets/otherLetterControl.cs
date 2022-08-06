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

    void Awake()
    {
        image = this.gameObject.GetComponent<Image>();
        image.sprite = letters[currentLetter];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);
        }
    }
    void readingSelfLetter()
    {
        currentLetter = 0;
    }
}
