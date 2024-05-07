using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public InputField nameInputField;

    public void StartGame()
    {
        // Store the entered name in PlayerPrefs (can also be stored in a database)
        PlayerPrefs.SetString("PlayerName", nameInputField.text);

        // Load the Game scene
        SceneManager.LoadScene("Game");
    }
}
