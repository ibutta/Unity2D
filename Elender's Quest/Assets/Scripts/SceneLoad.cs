using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    
    public void LoadNextScene()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(++activeSceneIndex);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void CloseApplication()
    {
        Application.Quit();
    }
}
