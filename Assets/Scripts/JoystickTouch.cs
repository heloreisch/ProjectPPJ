
using UnityEngine;

public class JoystickTouch : MonoBehaviour
{
    [Range(0.001f, 0.1f)]
    public float sensibilidade = 0.01f;

    private int idToque = -1;
    private float ultimaPosicaoX;

    void Update()
    {
        if (Input.touchCount == 0)
        {
            idToque = -1;
            return;
        }

        foreach (Touch toque in Input.touches)
        {
            if (toque.phase == TouchPhase.Began && idToque == -1)
            {
                idToque = toque.fingerId;
                ultimaPosicaoX = toque.position.x;
            }

            if (toque.fingerId == idToque)
            {
                if (toque.phase == TouchPhase.Moved)
                {
                    float deltaX = toque.position.x - ultimaPosicaoX;

                    float movimentoX = deltaX * sensibilidade;

                    transform.Translate(
                        Vector3.right * movimentoX,
                        Space.World
                    );

                    ultimaPosicaoX = toque.position.x;
                }

                if (toque.phase == TouchPhase.Ended ||
                    toque.phase == TouchPhase.Canceled)
                {
                    idToque = -1;
                }
            }
        }
    }
}
