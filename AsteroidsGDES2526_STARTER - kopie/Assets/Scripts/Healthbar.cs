using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public float health;
    public int points;
    public Slider healthSlider;
    private float maxHealth;

    private void Start()
    {
        maxHealth = health;
    }

    private void Update()
    {
        healthSlider.value = health / maxHealth;
        
        if (health <= 0)
        {
            GameManager.Instance.score += points;

            GameManager.finalScore = GameManager.Instance.score;

            AudioManager.Instance.LevelMusicIndex(2);

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
