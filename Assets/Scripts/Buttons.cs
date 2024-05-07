using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Define your buttons
    public void PlayButton()
    {
        // Load the Game scene
        SceneManager.LoadScene("Game");
    }

    public void StopButton()
    {
        // Load the Exit scene
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgainButton()
    {
        // Load the Intro scene
        SceneManager.LoadScene("Intro");
    }

    public void QuitButton()
    {
        // Quit the application
        Application.Quit();
    }
}
