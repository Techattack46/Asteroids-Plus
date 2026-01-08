using UnityEngine;
using UnityEngine.UI;

public class HealthBarVisual : MonoBehaviour
{
    public Slider healthSlider;

    public void SetHealth()
    {
        healthSlider.value = Healthbar.health;
    }
}
