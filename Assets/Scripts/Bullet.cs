using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // Speed of the bullet
    public float lifetime = 5f; // How long the bullet exists before being destroyed
    public int damage = 10; // Damage the bullet deals

    void Start()
    {
        // Destroy the bullet after its lifetime
        Destroy(gameObject, lifetime);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed;
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        // Example: If the bullet hits an enemy, deal damage and destroy the bullet
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddScore(1); // Add 1 Points (you can change this value)
        }
        // Destroy the bullet on collision
        Destroy(gameObject);
    }
}

