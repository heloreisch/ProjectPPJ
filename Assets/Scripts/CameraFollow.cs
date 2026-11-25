
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    private Vector3 deslocamento;
    private Quaternion rotacaoInicial;

    private void Start()
    {
        if (player == null) return;

        // Guarda a posição configurada no Transform da câmera
        deslocamento = transform.position - player.position;

        // Guarda a rotação configurada no Inspector
        rotacaoInicial = transform.rotation;
    }

    private void LateUpdate()
    {
        if (player == null) return;

        // Acompanha o jogador mantendo a posição inicial relativa
        transform.position = player.position + deslocamento;

        // Mantém a rotação definida no Inspector
        transform.rotation = rotacaoInicial;
    }
}