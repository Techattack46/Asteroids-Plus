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
        AudioManager.Instance.LevelMusicIndex(1);
        
        GameObject boss = Instantiate(bossPrefab);

        GameManager.Instance.bossHasSpawned = true;

        AsteroidWipe();

        boss.GetComponent<Rigidbody>().AddForce(-transform.forward * entranceSpeed);
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
