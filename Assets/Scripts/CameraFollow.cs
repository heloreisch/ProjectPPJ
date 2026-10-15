
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    [Header("Posição da câmera")]
    public float altura = 2.5f;
    public float distancia = 4f;

    [Header("Inclinação da câmera")]
    public float inclinacao = 15f;

    private void LateUpdate()
    {
        if (player == null) return;

        // Acompanha a posição da bola
        transform.position = player.position
            + new Vector3(0f, altura, -distancia);

        // Mantém a câmera estável, sem girar com a bola
        transform.rotation = Quaternion.Euler(
            inclinacao, 0f, 0f
        );
    }
}
