using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shootscript : MonoBehaviour
{
    public GameObject BulletPrefab; // Reference to your bullet prefab
    public Transform ShootPoint; // The point from where the bullet will be fired
    public float fireRate = 0.5f; // Time between shots
    public float bulletSpeed = 20f; //How fast the bullet moves

    private float nextFireTime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
       // Get camera direction

        Camera cam = Camera.main;

        Vector3 shootDirection = cam.transform.forward;

        // Instantiate the bullet at the shoot point

        GameObject bullet = Instantiate(BulletPrefab, ShootPoint.position, Quaternion.LookRotation(shootDirection));

        // Make sure the bullet has a Rigidbody and give it velocity

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)

        {

            rb.linearVelocity = shootDirection * bulletSpeed;

        }
    }
}