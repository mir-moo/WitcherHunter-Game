using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HunterBallEventsController : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        _score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Constants.Tags.WitcherTag))
        {
            _score++;
            _scoreText.text = _score.ToString();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(Constants.Tags.WitcherShieldTag))
        {
            PlayerPrefs.SetInt(Constants.PrefsLabels.ScoreLabel, _score);
            SceneManager.LoadScene(Constants.SceneNames.FailedScene);

            #region
            //_scoreText.text = _score.ToString();
            //Destroy(collision.gameObject);
            #endregion
        }
    }
}
