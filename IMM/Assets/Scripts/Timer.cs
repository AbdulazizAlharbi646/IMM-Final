using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // The panel object
    [SerializeField] private GameObject panel;

    // Text object that will display the time
    [SerializeField] private TextMeshProUGUI tmpText;

    // The current time passed
    private float currentTime;

    private void Update()
    {
        // Check if panel is active, if so, do nothing
        if (panel.activeInHierarchy) return;

        // Add the time passed for this frame and ensure the time scale does not affect it
        currentTime += Time.deltaTime / Time.timeScale;

        // Update the text and format the string to display as a minute timer
        tmpText.text = string.Format("{0}:{1:00}", (int)currentTime / 60, (int)currentTime % 60);
    }
}
