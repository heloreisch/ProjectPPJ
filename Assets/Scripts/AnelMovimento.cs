
using UnityEngine;

public class AnelMovimento : MonoBehaviour
{
    [Header("Rotação")]
    public float velocidadeRotacao = 60f;

    [Header("Movimento vertical")]
    public float amplitude = 0.5f;
    public float velocidadeSubida = 1f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.localPosition;
    }

    void Update()
    {
        // Faz o anel girar
        transform.Rotate(Vector3.up * velocidadeRotacao * Time.deltaTime);

        // Faz o anel subir e descer
        float movimento = Mathf.Sin(Time.time * velocidadeSubida) * amplitude;

        transform.localPosition = posicaoInicial + new Vector3(0, movimento, 0);
    }
}
