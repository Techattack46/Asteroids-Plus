using UnityEngine;

public class GunSecondary : MonoBehaviour
{
    public GameObject player;
    public GameObject laserPrefab;
    public float bulletSpeed;
    public float spawnDistance;
    private Vector3 firingVector;
    public AudioClip laserSound;
    public float lifetime;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && GameManager.Instance.itemEquipped)
        {
            ShootSecondary();
        }
    }

    private void ShootSecondary()
    {
        firingVector = (player.transform.forward * spawnDistance) + player.transform.position;

        GameObject laser = Instantiate(laserPrefab, firingVector, player.transform.rotation);

        laser.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        AudioManager.Instance.PlayClip(laserSound);

        Destroy(laser, lifetime);
    }
}
