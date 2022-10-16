using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSessionManager : MonoBehaviour
{
    private float _timer;

    private Health _player;

    public float sessionTime;

    public TextMeshProUGUI timerDisplay;

    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        _player.OnDie += EndSession;

        _timer = sessionTime;

        UnpauseGame();
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            EndSession();
        }

        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        timerDisplay.text = ((int)_timer + 1).ToString();
    }

    public void EndSession()
    {
        PauseGame();

        gameOverMenu.SetActive(true);
    }

    public void RestartSession()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;

        pauseMenu.SetActive(true);
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;

        pauseMenu.SetActive(false);
    }
}