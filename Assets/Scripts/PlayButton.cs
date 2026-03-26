using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayButton : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
