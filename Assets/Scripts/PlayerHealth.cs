using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public HealthSystem healthSystem;
    public Text healthText; 

    void Start()
    {
        healthSystem = new HealthSystem(100);
        healthSystem.OnHealthChanged += UpdateHealthUI;
        UpdateHealthUI(healthSystem.Health);
    }

    public void TakeDamage(int damage)
    {
        healthSystem.Health -= damage;
        if (healthSystem.IsDead())
        {
            Debug.Log("Jugador muerto");
            
        }
    }

    void UpdateHealthUI(int health)
    {
        if (healthText != null)
            healthText.text = "Vida: " + health;
    }
}
