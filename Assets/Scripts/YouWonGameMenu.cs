using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class YouWonGameMenu : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("ScenePlayerAttack"); // Ganti "GameScene" dengan nama adegan permainan Anda
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackToMap()
    {
        // Mengakses skrip "Money" melalui GameObject.FindObjectOfType.
        //Money moneyScript = GameObject.FindObjectOfType<Money>();

       

        
         SceneManager.LoadScene("MapScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}