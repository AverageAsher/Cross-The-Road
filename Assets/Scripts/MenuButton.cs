using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void StartGame()
    {
        Time.timeScale = 1;
        // Load the first scene in the build settings
        SceneManager.LoadScene(0);
    }
}