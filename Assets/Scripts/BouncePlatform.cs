
using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
    public float jumpForce = 12f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

            if (playerRb != null)
            {
                playerRb.velocity = new Vector3(
                    playerRb.velocity.x,
                    0f,
                    playerRb.velocity.z
                );

                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
