using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class YouLoseGameMenu : MonoBehaviour
{



    public void StartGame()
    {
        SceneManager.LoadScene("SceneEnemyAttack"); // Ganti "GameScene" dengan nama adegan permainan Anda
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SceneMovement"); // Ganti "GameScene" dengan nama adegan permainan Anda
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}