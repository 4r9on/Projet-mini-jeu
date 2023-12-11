using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadingScene : MonoBehaviour
{
    public string SceneName;
    public string SceneName1;
    public string SceneName2;
    public string SceneName3;
    public string SceneName4;


    public void LoadGame1()
    {
        SceneManager.LoadScene(SceneName1);
    }

    public void LoadGame2()
    {
        SceneManager.LoadScene(SceneName2); 
    }

    public void LoadGame3()
    {
        SceneManager.LoadScene(SceneName3);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneName4);
    }
}
