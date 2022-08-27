using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class endTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI finalText;
    public Image background;

    public float delayTime = 0;
    private bool start = false;

    public Transform backgroundMusicTrigger;
    private AudioSource endMusic;

    private float playTime = 0f;
    private float minTime = 5f;
    void Start()
    {
        endMusic = backgroundMusicTrigger.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (start)
        {
            if (!endMusic.isPlaying)
            {
                if(playTime < minTime)
                {
                    playTime = playTime + Time.deltaTime;
                }
                else
                {
                    SceneManager.LoadScene("StartMenu");
                }
            }
            else
            {
                playTime = playTime + Time.deltaTime;
            }
        }
    } 


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            background.gameObject.SetActive(true);
            finalText.gameObject.SetActive(true);
            start = true;
        }
    }
}
