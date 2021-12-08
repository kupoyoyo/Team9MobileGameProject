using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject startMenu;
    public GameObject resumeButton;

    public AudioSource mainMenuBGM;

    // Start is called before the first frame update
    void Start()
    {
        //startMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void PauseGame()
    {
        if (pauseButton)
        {
            Time.timeScale = 0;
            startMenu.SetActive(true);
        }
        if (resumeButton)
        {
            Time.timeScale = 1;
            startMenu.SetActive(false);
        }
    }

    
}
