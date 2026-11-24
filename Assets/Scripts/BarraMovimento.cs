
using UnityEngine;

public class BarraMovimento : MonoBehaviour
{
    public float altura = 2f;
    public float velocidade = 1f;
    public float atraso = 0f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        float movimento = Mathf.PingPong(
            (Time.time + atraso) * velocidade,
            altura
        );

        transform.position = posicaoInicial +
            new Vector3(0f, movimento, 0f);
    }
}
