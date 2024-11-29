using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 1000000;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player Died");
        // Add death logic here (e.g., reload scene, display game over)
    }
}
