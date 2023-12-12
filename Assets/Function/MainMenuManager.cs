using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MapScene"); // Ganti "GameScene" dengan nama adegan permainan Anda
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("SampleScene"); // Ganti "GameScene" dengan nama adegan permainan Anda
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}