
using UnityEngine;
using System.Collections;

public class MovimentoPlayer : MonoBehaviour
{
    public float forwardSpeed = 8f;

    private float velocidadeNormal;
    private Rigidbody rb;
    private Coroutine efeitoSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        velocidadeNormal = forwardSpeed;
    }

    private void FixedUpdate()
    {
        if (rb == null) return;

        Vector3 velocity = rb.velocity;
        velocity.z = forwardSpeed;
        rb.velocity = velocity;
    }

    public void AtivarSpeed(float aumento, float duracao)
    {
        if (efeitoSpeed != null)
            StopCoroutine(efeitoSpeed);

        efeitoSpeed = StartCoroutine(
            SpeedTemporario(aumento, duracao)
        );
    }

    private IEnumerator SpeedTemporario(
        float aumento, float duracao)
    {
        forwardSpeed = velocidadeNormal + aumento;

        yield return new WaitForSeconds(duracao);

        forwardSpeed = velocidadeNormal;
        efeitoSpeed = null;
    }
}
