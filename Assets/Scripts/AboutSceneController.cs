using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutSceneController : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(Constants.SceneNames.AboutScene); // 3
    }
}
