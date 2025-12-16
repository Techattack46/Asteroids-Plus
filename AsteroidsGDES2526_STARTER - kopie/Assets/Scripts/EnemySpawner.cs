using UnityEditor.Search;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public AudioClip bossMusic;
    public GameObject bossPrefab;
    public float entranceSpeed;

    private void Update()
    {
        if (!GameManager.Instance.bossHasSpawned && GameManager.Instance.bossMayEnter)
        {
            BossSpawn();
        }
    }

    private void BossSpawn()
    {
        AudioManager.Instance.PlayLevelMusicIndex(1);
        
        GameObject boss = Instantiate(bossPrefab);
        Debug.Log("Boss is spawning now.");

        GameManager.Instance.bossHasSpawned = true;

        boss.GetComponent<Rigidbody>().AddForce(-transform.forward * entranceSpeed);
    }
}
