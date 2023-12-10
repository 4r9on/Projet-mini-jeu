using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{
    public Activated activated;
    public GameObject start;
    public GameObject playButton;
    public GameObject three;
    public GameObject two;
    public GameObject one;
    public GameObject go;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (activated.isActive)
        {
            playButton.SetActive(true);
        }
        else
        {
            playButton.SetActive(false);
        }
    }

    public void PlayPressed()
    {
        StartCoroutine(ButtonPlay());
    }

    IEnumerator ButtonPlay()
    {
        three.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        three.SetActive(false);
        two.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        two.SetActive(false);
        one.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        one.SetActive(false);
        go.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 1;
        start.SetActive(false);
    }
}
