using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 5f; // Time before the projectile is destroyed

    void Start()
    {
        // Destroy the projectile after a certain amount of time
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the projectile collides with the player
        if (collision.CompareTag("Player"))
        {
            // Make the player flash red
            PlayerFlash playerFlash = collision.GetComponent<PlayerFlash>();
            if (playerFlash != null)
            {
                playerFlash.FlashRed();
            }

            // Destroy the projectile
            Destroy(gameObject);
        }

        // Optional: Destroy the projectile if it hits something else (like walls)
        if (collision.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
