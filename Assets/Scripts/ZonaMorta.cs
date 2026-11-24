
using UnityEngine;

public class ZonaMorta : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.gm.GameOver();
        }
    }
}
