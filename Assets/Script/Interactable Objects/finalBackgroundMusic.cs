using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalBackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private bool played = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            if (other.CompareTag("player"))
            {
                this.GetComponent<AudioSource>().Play();
                played = true;
            }
        }
    }
}
