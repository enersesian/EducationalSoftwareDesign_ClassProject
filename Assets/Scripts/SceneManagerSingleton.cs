using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSingleton : MonoBehaviour
{
    public static SceneManagerSingleton sceneManagerSingleton;

    void Start()
    {
        if(sceneManagerSingleton == null)
        {
            sceneManagerSingleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public static void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
