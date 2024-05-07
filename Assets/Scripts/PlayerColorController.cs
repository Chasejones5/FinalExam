using UnityEngine;
using UnityEngine.UI;

public class PlayerColorController : MonoBehaviour
{
    public GameObject playerSphere;
    public Dropdown colorDropdown;

    void Start()
    {
        // Add listener to the Dropdown's value change event
        colorDropdown.onValueChanged.AddListener(delegate { ChangePlayerColor(); });
    }

    void ChangePlayerColor()
    {
        // Get the index of the selected color option
        int selectedColorIndex = colorDropdown.value;

        // Set the new color based on the selected index
        Color newColor = Color.white; // Default color (if color options are not set)

        switch (selectedColorIndex)
        {
            case 1:
                newColor = Color.red;
                break;
            case 2:
                newColor = Color.green;
                break;
            case 3:
                newColor = Color.blue;
                break;
        }

        // Change the color of the player sphere
        Renderer playerRenderer = playerSphere.GetComponent<Renderer>();
        playerRenderer.material.color = newColor;
    }
}
