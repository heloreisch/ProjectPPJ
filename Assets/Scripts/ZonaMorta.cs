
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaMorta : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}