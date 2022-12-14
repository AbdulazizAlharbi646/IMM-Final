using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // The damage this obstacle deals (defaults to 20)
    public int damage = 20;

    private void OnTriggerEnter(Collider other)
    {
        // Try to get a health bar from the object that was collided with
        // Nothing happens if a health bar is not found
        if (other.TryGetComponent(out HealthBar healthBar))
        {
            // If a health bar is found, apply damage
            healthBar.ApplyDamage(damage);
        }
    }
}
