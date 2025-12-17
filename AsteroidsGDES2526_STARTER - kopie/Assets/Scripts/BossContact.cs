using UnityEngine;

public class BossContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ContactDestroy.PlayerDeath();
        }
    }
}
