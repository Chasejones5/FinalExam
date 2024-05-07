using UnityEngine;
using UnityEngine.UI;

public class GameScene : MonoBehaviour
{
    public Text nameText;

    void Start()
    {
        // Retrieve the player name from PlayerPrefs
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");

        // Update the NameText with the player's name
        nameText.text = "Name: " + playerName;
    }
}
