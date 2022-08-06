using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform intro;
    public Transform startMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadMainScene()
    {
        intro.gameObject.SetActive(true);
        startMenu.gameObject.SetActive(false);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
