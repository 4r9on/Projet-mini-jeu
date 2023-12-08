using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public void OpenCanva(GameObject Canva)
    {
        Canva.SetActive(true);
    }

    public void CloseCanva(GameObject Canva)
    {
        Canva.SetActive(false);
    }

    public void SwitchScene(string NameOfScene)
    {

        SceneManager.LoadScene(NameOfScene);
    }
}
