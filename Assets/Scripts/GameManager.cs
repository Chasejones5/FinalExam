using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform spawnArea;
    public int targetCount = 5;
    public int score = 0;
    private bool isPaused = false;

    void Update()
    {
        // Check for input to pause or resume the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }
    void Start()
    {
        // Spawn targets
        SpawnTargets();
    }

    void SpawnTargets()
    {
        for (int i = 0; i < targetCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), 0f);
            Instantiate(targetPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void TargetDestroyed()
    {
        score++;

        if (score >= targetCount)
        {
            // Automatically move to the Exit scene
            MoveToExitScene();
        }
    }

    public void MoveToExitScene()
    {
        // Add player name and score to the database
        SceneManager.LoadScene("Exit");
    }
    void TogglePause()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        // Pause or resume the game based on the pause state
        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Freeze time
        // Add any additional logic to pause the game (e.g., disable player input, show pause menu)
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Resume time
        // Add any additional logic to resume the game (e.g., enable player input, hide pause menu)
    }
}
