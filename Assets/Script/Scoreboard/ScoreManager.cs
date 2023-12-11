using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    //Lien du tuto : https://www.youtube.com/watch?v=-O7zeq7xMLw
    [SerializeField] private TextMeshProUGUI inputScore;
    [SerializeField] TMP_InputField inputName;

    public UnityEvent<string, int> submitScoreEvent;

    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
