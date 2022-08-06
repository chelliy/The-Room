using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class introControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float displayTime = 3f;
    public string mainScene = "MainGame";
    public TextMeshProUGUI intro;
    private float baseTime;
    private float baseAlpha;
    void Start()
    {
        baseTime = displayTime;
        baseAlpha = intro.alpha;
        intro.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(displayTime > 0)
        {
            displayTime = displayTime - Time.deltaTime;
            intro.alpha = (1- displayTime / baseTime) * baseAlpha;
        }
        else
        {
            loadMainScene();
        }
    }

    void loadMainScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
