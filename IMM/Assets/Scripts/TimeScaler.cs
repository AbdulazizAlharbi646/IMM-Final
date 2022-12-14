using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    // The speed of time (defaults to 1)
    [SerializeField] private float timeScale = 1;

    // The panel object
    [SerializeField] private GameObject panel;

    private void Update()
    {
        // Check if panel is active, if so, do nothing
        if (panel.activeInHierarchy) return;

        // Update the time scale to match set time scale
        Time.timeScale = timeScale;
    }
}
