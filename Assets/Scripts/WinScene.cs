using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    // Name of the scene to load when winning
    public string winSceneName = "WinScene";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a specific tag (you can customize this)
        if (other.CompareTag("Player"))
        {
            // Load the win scene
            SceneManager.LoadScene(2);
        }
    }
}