using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager; // Reference to the GameManager script

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is a target
        if (other.CompareTag("Target"))
        {
            // Destroy the target
            Destroy(other.gameObject);

            // Increase the score
            gameManager.TargetDestroyed();
        }
    }
}
