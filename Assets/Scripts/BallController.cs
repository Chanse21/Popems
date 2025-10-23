using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // don't fall down
        // Give the ball an initial velocity
        rb.linearVelocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Get the incoming velocity of the ball
        Vector3 incomingDirection = rb.linearVelocity.normalized;

        // Get the normal of the surface the ball collided with
        Vector3 surfaceNormal = collision.contacts[0].normal;

        // Calculate the reflected direction
        Vector3 reflectedDirection = Vector3.Reflect(incomingDirection, surfaceNormal);

        // Apply the new velocity to the ball, maintaining the original speed
        rb.linearVelocity = reflectedDirection * speed;
    }
}