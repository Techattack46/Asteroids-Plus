using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject standardBullet;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (standardBullet || player)
        {
            GameManager.Instance.ItemEquip();
            Destroy(gameObject);
        }
    }
}
