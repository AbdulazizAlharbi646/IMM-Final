using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Bullet : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    float speed = 15;

    // A destroy sound effect
    [SerializeField] private AudioClip destroySoundEffect;

    // Destroy particle system to use
    [SerializeField] private ParticleSystem destroyEffect;

    public Vector3 currentPos { get; set; }

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Check if destroy sound effect is set
            if (destroySoundEffect)
            {
                // Play the sound effect
                AudioSource.PlayClipAtPoint(destroySoundEffect, transform.position, 1f);

                // Instantiate the destroy effect
                ParticleSystem effect = Instantiate(destroyEffect).GetComponent<ParticleSystem>();

                // Move the effect to the position of the destroyed object
                effect.transform.position = other.transform.position;

                // Play the effect
                effect.Play();

                // Destroy the effect after a short delay
                Destroy(effect.gameObject, 1f);
            }

            Destroy(other.gameObject);
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}