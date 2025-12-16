using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject bossPrefab;

    public void Update()
    {
        if (!GameManager.Instance.bossHasSpawned && GameManager.Instance.bossMayEnter)
        {
            Instantiate(bossPrefab);
            Debug.Log("Boss is spawning now.");
            
            GameManager.Instance.bossHasSpawned = true;
        }
    }
}
