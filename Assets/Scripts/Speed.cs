using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speedIncrease = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        Rigidbody rb = other.attachedRigidbody;

        if (rb == null)
            rb = other.GetComponentInParent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogWarning("Player sem Rigidbody!");
            return;
        }

        rb.AddForce(
            transform.forward * speedIncrease,
            ForceMode.VelocityChange
        );
    }
}