using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public Ui ui;
    public ScoreManager scoreManager;


    private void Start()
    {
        scoreManager.AddScore(new Score("eran", 10));
        scoreManager.AddScore(new Score("eran2", 20));


        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(ui, transform).GetComponent<Ui>();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}
