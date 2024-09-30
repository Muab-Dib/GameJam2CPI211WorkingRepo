using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] hearts; // Assign your heart images in the Unity inspector
    public Sprite fullHeart; // Sprite for full heart
    public Sprite emptyHeart; // Sprite for empty heart

    public FirstPersonMovement player; // Reference to your player script

    private void Update()
    {
        UpdateHearts();
    }

    private void UpdateHearts()
    {
        int currentHealth = player.CurrHealth;

        // Update each heart image based on the player's current health
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
