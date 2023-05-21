using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void ReloadCurrScene()
    {
        var currScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currScene.name);
        Time.timeScale = 1f;
    }
}
