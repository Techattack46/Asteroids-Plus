using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public int health;
    public int points;

    private void Update()
    {
        if (health <= 0)
        {
            GameManager.Instance.score += points;
            
            SceneManager.LoadScene(4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            TakeDamage(other.gameObject.GetComponent<BulletDamage>().bulletDamage);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
