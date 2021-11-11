using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool gamePaused = false;

    [SerializeField]
    private GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        //pausePanel = GameObject.Find("PausePanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        if (!gamePaused)
        {
            gamePaused = true;
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            gamePaused = false;
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }
}
