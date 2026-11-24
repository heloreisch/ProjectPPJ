using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonLoadLevel : MonoBehaviour
{
    public string nomeDaCena;

    public void LoadLevel()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
