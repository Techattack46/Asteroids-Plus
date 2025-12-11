using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    public int points;

    private void OnDestroy()
    {
        GameManager.Instance.score += points;
    }
}
