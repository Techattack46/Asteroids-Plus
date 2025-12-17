using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactDestroy : MonoBehaviour
{
    public AudioClip hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag(collision.gameObject.tag))
        {
            return;
        }

        else if (!gameObject.CompareTag("Projectile"))
        {
            AudioManager.Instance.PlayClip(hitSound);
        }

        if (collision.gameObject.CompareTag("Item"))
        {
            return;
        }

        else if (gameObject.CompareTag("Asteroid") && collision.gameObject.CompareTag("Player"))
        {   
            return;
        }

        else if (gameObject.CompareTag("Player"))
        {
            PlayerDeath();
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    public static void PlayerDeath()
    {
        GameManager.finalScore = GameManager.Instance.score;

        SceneManager.LoadScene(3);

        AudioManager.Instance.LevelMusicIndex(0);
    }
}
