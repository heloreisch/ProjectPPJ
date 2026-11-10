using UnityEngine;

public class MovimentoLateralEsquerda : MonoBehaviour
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
        float movimento = distancia -
            Mathf.PingPong(Time.time * velocidade, distancia * 2);

        transform.position = posicaoInicial +
            new Vector3(movimento, 0, 0);
    }
}