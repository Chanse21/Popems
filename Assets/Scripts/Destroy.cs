using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void OnCollisionEnter(Collision collision)
    {
        // Example: If the bullet hits an enemy, deal damage and destroy the bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Assuming the enemy has a script with a TakeDamage method
            // collision.gameObject.GetComponent<EnemyScript>().TakeDamage(damage);
        }

        // Destroy the bullet on collision
        Destroy(gameObject);
    }
}