using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    // Name of the scene to load when the player wins
    public string winSceneName;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with the object tagged as "WinTrigger"
        if (other.CompareTag("WinTrigger"))
        {
            // Load the win scene
            SceneManager.LoadScene(winSceneName);
        }
    }
}