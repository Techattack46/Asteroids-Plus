using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public float spawnDistance;
    private Vector3 firingVector;
    public AudioClip gunSound;
    public float lifetime;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        firingVector = (player.transform.forward * spawnDistance) + player.transform.position;
        
        GameObject bullet = Instantiate(bulletPrefab, firingVector, player.transform.rotation);

        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        AudioManager.Instance.PlayClip(gunSound);

        Destroy(bullet, lifetime);
    }

}
