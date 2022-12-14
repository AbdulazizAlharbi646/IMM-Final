using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // The UI slider that acts as the health bar
    [SerializeField] private Slider slider;

    // The object that displays the amount of HP in a text format
    [SerializeField] private TextMeshProUGUI textAmount;

    private void Start()
    {
        // Ensure the text is accurate at the start
        UpdateText();
    }

    /// <summary>
    /// Removes a specified amount of HP.
    /// </summary>
    /// <param name="amount">The amount of HP to remove.</param>
    public void ApplyDamage(int amount)
    {
        // Subtract an amount from the slider
        slider.value -= amount;
        
        // Call a function that updates the text
        UpdateText();

        // If HP is 0
        if (slider.value == 0)
        {
            // Ask to restart the level
            GameManager.gameManager.menu.OpenMenuPanel();
        }
    }

    /// <summary>
    /// Simply updates the text of the health bar.
    /// </summary>
    private void UpdateText()
    {
        // Update the text to reflect the current values
        textAmount.text = slider.value + " / " + slider.maxValue;
    }
}
