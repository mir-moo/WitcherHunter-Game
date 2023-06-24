using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(Constants.SceneNames.GameScene); // 1
    }

    public void AboutPage()
    {
        SceneManager.LoadScene(Constants.SceneNames.AboutScene); // 3
    }

    public void HelpPage()
    {
        SceneManager.LoadScene(Constants.SceneNames.HelpScene); // 4
    }

    public void Exit()
    {
        Application.Quit();
        //Debug.Log("exit");

        //#if UNITY_STANDALONE
        //        Application.Quit();
        //#endif
        //#if UNITY_EDITOR
        //        UnityEditor.EditorApplication.isPlaying = false;
        //#endif
    }
}
