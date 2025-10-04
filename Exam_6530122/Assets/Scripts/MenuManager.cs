using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadFetchGame()
    {
        SceneManager.LoadScene("Challenge 2");
    }

    public void LoadFlyingGame()
    {
        SceneManager.LoadScene("Challenge 1");
    }

    public void LoadSoccerGame()
    {
        SceneManager.LoadScene("Challenge 4");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // Stops play mode in Editor
#else
            Application.Quit(); // Works in builds
#endif
    }
}
