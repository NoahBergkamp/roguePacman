using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayButton : MonoBehaviour
{
    public void StartGame1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void StartGame2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
