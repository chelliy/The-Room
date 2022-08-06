using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite[] letters;

    private Image image;
    [SerializeField]
    public int currentLetter= 0;

    public bool[] counters;
    void Awake()
    {
        image = this.gameObject.GetComponent<Image>();
        image.sprite = letters[currentLetter];
        counters = new bool[letters.Length];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentLetter--;
            if (currentLetter < 0)
            {
                currentLetter = letters.Length - 1;
            }
            image.sprite = letters[currentLetter];
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentLetter++;
            if (currentLetter > letters.Length - 1)
            {
                currentLetter = 0;
            }
            image.sprite = letters[currentLetter];
        }
        counters[currentLetter] = true;
    }
}
