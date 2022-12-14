using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided is the player
        if (other.CompareTag("Player"))
        {
            // Get the current scene
            var scene = SceneManager.GetActiveScene();

            // Find the level by the name of the scene
            // First, remove Level from the name, leaving only the number string
            string levelString = scene.name.Replace("Level", "");

            // Get the level by converting string to int
            int level = int.Parse(levelString);

            // Increment level by 1 to get the next level
            level++;

            // Get the scene name of the next level
            string nextLevelName = "Level" + level;

            // Check if the next level exists
            if (Application.CanStreamedLevelBeLoaded(nextLevelName))
            {
                // Load next level
                SceneManager.LoadScene(nextLevelName);
            }
            // If level does not exist
            else
            {
                // Load main menu
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
