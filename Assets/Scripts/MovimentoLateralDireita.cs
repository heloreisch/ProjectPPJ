
using UnityEngine;

public class MovimentoLateral : MonoBehaviour
{
    public float distancia = 3f;
    public float velocidade = 2f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        float movimento = Mathf.PingPong(
            Time.time * velocidade,
            distancia * 2
        ) - distancia;

        transform.position = posicaoInicial +
            new Vector3(movimento, 0, 0);
    }
}
