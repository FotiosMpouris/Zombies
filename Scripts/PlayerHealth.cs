using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 200f;
    [SerializeField] TextMeshProUGUI playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthDisplay();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }

        // Update the health display whenever the player takes damage
        UpdateHealthDisplay();
    }

    void UpdateHealthDisplay()
    {
        // Ensure the TextMeshProUGUI component is assigned
        if (playerHealthText != null)
        {
            // Update the displayed health value
            playerHealthText.text = "Health: " + hitPoints.ToString();
        }
    }
}
