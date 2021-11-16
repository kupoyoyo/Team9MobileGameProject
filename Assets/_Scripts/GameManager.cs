using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool gamePaused = false;
    [SerializeField] private string sceneName = "";

    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI scoreText;

    public int score = 0;

    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        gamePaused = false;
        Time.timeScale = 1;
        score = 0;
        scoreText.text = "SCORE: " + score;
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score;
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

    public void Restart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }    
}
