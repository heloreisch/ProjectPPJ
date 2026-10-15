
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    public float forwardSpeed = 8f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (rb == null) return;

        Vector3 velocity = rb.velocity;
        velocity.z = forwardSpeed;

        rb.velocity = velocity;
    }
}
