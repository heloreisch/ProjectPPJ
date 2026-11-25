
using UnityEngine;

public class ReiniciarMusica : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.Stop();
        audioSource.time = 0f;
        audioSource.Play();
    }
}
