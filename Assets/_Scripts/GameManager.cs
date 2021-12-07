using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool gamePaused = false;
    //[SerializeField] private string sceneName = "";
    [SerializeField] private int sceneIndex;

    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private AudioSource mainCamera;

    public int score = 0;

    void Start()
    {
        //sceneName = SceneManager.GetActiveScene().name;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
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
            mainCamera.Pause();
        }
        else
        {
            gamePaused = false;
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            mainCamera.Play();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void LevelOver()
    {
        Time.timeScale = 0;
        endPanel.SetActive(true);
    }
}
