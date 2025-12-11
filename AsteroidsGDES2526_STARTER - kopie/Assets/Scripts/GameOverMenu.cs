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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
