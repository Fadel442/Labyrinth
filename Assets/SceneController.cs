using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SceneLoad()
        {
         SceneManager.LoadScene("GamePlay");
         Time.timeScale = 1f;
        }

    public void QuitScene()
    {
        Application.Quit();
    }
}
