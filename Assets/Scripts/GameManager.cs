using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    private bool isGameOver = false;

    [Header("UI Settings")]
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject gameOverPanel;

    public void TogglePauseMenu()
    {
        bool paused = pauseMenu.activeSelf;
        pauseMenu.SetActive(!paused);
        Time.timeScale = paused ? 1f : 0f;
    }
    private void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void MoveScene()
    {
        // Movimiento de tiles para simular avance
    }


}
