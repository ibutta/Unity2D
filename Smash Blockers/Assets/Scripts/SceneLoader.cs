using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void LoadScene(int sceneIndex)
    {
        //yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(sceneIndex);
        
    }

    private void LoadScene(string sceneName)
    {
        //yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameOverScene()
    {
        FindObjectOfType<GameData>().ResetGameData();
        LoadScene("Game Over");
    }

    public void LoadNextScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
