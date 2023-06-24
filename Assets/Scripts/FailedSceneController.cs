using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailedSceneController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Start()
    {
        var score = PlayerPrefs.GetInt(Constants.PrefsLabels.ScoreLabel, 0);
        if (_scoreText != null)
            _scoreText.text = score.ToString();
        else
            PlayerPrefs.SetInt(Constants.PrefsLabels.ScoreLabel, 0);
            //_scoreText.text = "0";
    }
    public void RestratGame()
    {
        //_scoreText.text = "0";
        SceneManager.LoadScene(Constants.SceneNames.GameScene); // 1
    }
    public void GoToMenu()
    {
        //_scoreText.text = "0";
        SceneManager.LoadScene(Constants.SceneNames.MenuScene); // 0
    }
}
