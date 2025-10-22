using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody rb;

    void Start()

    {

        rb = GetComponent<Rigidbody>();

        // Make sure gravity is off if you want free-floating bouncing

        rb.useGravity = false;

        // Give the sphere an initial random direction

        Vector3 randomDirection = Random.onUnitSphere;

        // Apply initial velocity

        rb.linearVelocity = randomDirection * speed;

    }

}