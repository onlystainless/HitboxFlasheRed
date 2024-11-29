using UnityEngine;

public class PlayerFlash : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; // Reference to the player's SpriteRenderer
    public float flashDuration = 0.5f;    // Total duration of the flash effect
    public int flashCount = 3;            // Number of flashes (red and normal)

    private Color originalColor;          // To store the original sprite color

    void Start()
    {
        // Get the SpriteRenderer component and save the original color
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    public void FlashRed()
    {
        // Start the flashing coroutine
        StartCoroutine(Flash());
    }

    private System.Collections.IEnumerator Flash()
    {
        // Calculate the duration of each flash cycle
        float flashInterval = flashDuration / (flashCount * 2);

        for (int i = 0; i < flashCount; i++)
        {
            // Set the sprite color to red
            spriteRenderer.color = Color.red;

            // Wait for half a flash cycle
            yield return new WaitForSeconds(flashInterval);

            // Set the sprite color back to the original
            spriteRenderer.color = originalColor;

            // Wait for the other half of the flash cycle
            yield return new WaitForSeconds(flashInterval);
        }
    }
}
