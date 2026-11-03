
using UnityEngine;

public class PlatformColor : MonoBehaviour
{
    public Material touchMaterial;

    private Renderer platformRenderer;

    void Start()
    {
        platformRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            platformRenderer.material = touchMaterial;
        }
    }
}
