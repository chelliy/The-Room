using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class digitControl : MonoBehaviour
{
    private Text digit;
    // Start is called before the first frame update
    private int current = 0;
    public int max = 2;
    public int min = 0;
    void Start()
    {
        digit = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        digit.text = current.ToString();
    }

    public void decrease()
    {
        if (current > min)
        {
            current--;
        }
        else
        {
            current = max;
        }
    }
    public void increase()
    {
        if (current < max)
        {
            current++;
        }
        else
        {
            current = min;
        }
    }
}
