using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenLoader : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
