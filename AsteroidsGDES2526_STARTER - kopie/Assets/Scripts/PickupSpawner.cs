using UnityEngine;

//Copied from Rosa's
public class PickupSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float padding;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timer;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Spawn();
            ResetTimer();
        }
    }

    private void Spawn()
    {
        Instantiate(itemPrefab, GetRandomPositionOffScreen(), Quaternion.identity, transform);
    }

    private void ResetTimer()
    {
        timer = Random.Range(minSpawnTime, maxSpawnTime);
    }

    private Vector3 GetRandomPositionOffScreen()
    {
        int side = Random.Range(0, 4);

        float paddingWidth = Screen.width * padding;
        float paddingHeight = Screen.height * padding;

        Vector3 screenPosition = Vector3.zero;

        switch (side)
        {
            case 0:
                screenPosition = new Vector3(Random.Range(-paddingWidth, Screen.width + paddingWidth), Screen.height + paddingHeight);
                break;

            case 1:
                screenPosition = new Vector3(Screen.width + paddingWidth, Random.Range(-paddingHeight, Screen.height + paddingHeight));
                break;

            case 2:
                screenPosition = new Vector3(Random.Range(-paddingWidth, Screen.width + paddingWidth), -paddingHeight);
                break;

            case 3:
                screenPosition = new Vector3(-paddingWidth, Random.Range(-paddingHeight, Screen.height + paddingHeight));
                break;
        }

        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        spawnPosition.y = 0;
        return spawnPosition;
    }
}
