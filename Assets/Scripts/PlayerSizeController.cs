using UnityEngine;
using UnityEngine.UI;

public class PlayerSizeController : MonoBehaviour
{
    public Slider playerSizeSlider;
    public GameObject playerSphere;

    void Start()
    {
        // Add listener to the slider's value change event
        playerSizeSlider.onValueChanged.AddListener(delegate { ChangePlayerSize(); });
    }

    void ChangePlayerSize()
    {
        // Get the value of the slider
        float newSize = playerSizeSlider.value;

        // Clamp the value between 1 and 2
        newSize = Mathf.Clamp(newSize, 1f, 2f);

        // Set the scale of the player sphere
        playerSphere.transform.localScale = new Vector3(newSize, newSize, newSize);
    }
}
