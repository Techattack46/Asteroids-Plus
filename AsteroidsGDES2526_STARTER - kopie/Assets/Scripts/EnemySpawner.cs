using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public AudioClip bossMusic;
    public GameObject bossPrefab;
    public float entranceSpeed;
    public float entranceDuration;
    public Transform targetLocation;

    private void Update()
    {
        if (!GameManager.Instance.bossHasSpawned && GameManager.Instance.bossMayEnter)
        {
            BossSpawn();
        }
    }

    private void BossSpawn()
    {
        AudioManager.Instance.LevelMusicIndex(1);
        
        GameObject boss = Instantiate(bossPrefab);

        GameManager.Instance.bossHasSpawned = true;

        AsteroidWipe();

        StartCoroutine(MoveToTargetRoutine(boss));
    }

    private IEnumerator MoveToTargetRoutine(GameObject boss)
    {
        Vector3 startPosition = boss.transform.position;
        float time = 0f;
        while (time <= 1f)
        {
            time += Time.deltaTime / entranceDuration;
            boss.transform.position = Vector3.Lerp(startPosition, targetLocation.position, time);
            yield return null;
        }
    }

    private void AsteroidWipe()
    {
        GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Asteroid");

        foreach (GameObject asteroid in asteroids)
        {
            Destroy(asteroid);
        }
    }
}
