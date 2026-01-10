using UnityEngine;

public class RetryMusicLoad : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Instance.LevelMusicIndex(0);
    }
}
