using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Button sound effects
    [SerializeField] private AudioClip audioHover;
    [SerializeField] private AudioClip audioClick;

    /// <summary>
    /// Plays a hover sound effect.
    /// </summary>
    public void Hover()
    {
        // Play hover audio clip
        AudioSource.PlayClipAtPoint(audioHover, Vector3.zero, 1);
    }

    /// <summary>
    /// Plays a click sound effect.
    /// </summary>
    public void Click()
    {
        // Play click audio clip
        AudioSource.PlayClipAtPoint(audioClick, Vector3.zero, 1);
    }

    /// <summary>
    /// Starts the game.
    /// </summary>
    public void Play()
    {
        // Load level one
        SceneManager.LoadScene("Level1");
    }
}
