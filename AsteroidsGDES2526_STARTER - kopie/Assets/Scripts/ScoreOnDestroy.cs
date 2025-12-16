using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    public int points;

    private void OnDestroy()
    {
        if ((!GameManager.Instance.bossHasSpawned) && gameObject.CompareTag("Asteroid"))
        {
            GameManager.Instance.score += points;
        }

        else if (GameManager.Instance.bossHasSpawned && gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.score += points;
        }
    }
}
