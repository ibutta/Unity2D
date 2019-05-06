using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Blocks == 0)
        {
            LoadNextScene();
        }
    }

    public int Blocks { get; set; }
        
    private void LoadNextScene()
    {
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
