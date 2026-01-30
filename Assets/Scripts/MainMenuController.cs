using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private Button startButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartButtonClicked()
    {
        Debug.Log("Start Button Clicked!");
        SceneManager.LoadScene("GameScene");
        // Add logic to start the game
    }
}
