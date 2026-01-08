using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public string scene;
    public TextMeshProUGUI finalScoreText;

    private void Start()
    {
        finalScoreText.text = GameManager.finalScore.ToString();
    }

    private void Update()
    {
        RetryCheck();
        ReturnToStartupCheck();
    }

    private void RetryCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(scene);

            AudioManager.Instance.LevelMusicIndex(0);
        }
    }

    private void ReturnToStartupCheck()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);

            AudioManager.Instance.levelMusicSource.Stop();
        }
    }
}
