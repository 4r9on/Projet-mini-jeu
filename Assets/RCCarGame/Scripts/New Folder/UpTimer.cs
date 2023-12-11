using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float time;

    private void FixedUpdate()
    {
        UpTime();
    }

    public void DownTimer()
    {

    }

    public void UpTime()
    {
        time += Time.deltaTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
