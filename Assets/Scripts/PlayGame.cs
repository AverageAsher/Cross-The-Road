using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void StartGame()
    {
        // Load the first scene in the build settings
        SceneManager.LoadScene(1);
    }
}