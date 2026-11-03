
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speedIncrease = 5f;
    public float speedDuration = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        MovimentoPlayer movimento =
            other.GetComponentInParent<MovimentoPlayer>();

        if (movimento == null)
            return;

        movimento.AtivarSpeed(
            speedIncrease,
            speedDuration
        );
    }
}
