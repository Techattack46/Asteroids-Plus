using UnityEngine;

public class BossContact : MonoBehaviour
{
    public AudioClip deathSound;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            AudioManager.Instance.PlayClip(deathSound);
            ContactDestroy.PlayerDeath();
        }
    }
}
