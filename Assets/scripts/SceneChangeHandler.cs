using UnityEngine;
using UnityEngine.SceneManagement;

// Use from UI buttons or UnityEventOnTrigger to change scene or quit the game
public class SceneChangeHandler : MonoBehaviour
{
    // Type the scene name in the UnityEvent, e.g. "Level1"
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}