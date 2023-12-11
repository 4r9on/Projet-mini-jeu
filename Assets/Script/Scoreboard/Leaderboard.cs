using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dan.Main;
using TMPro;
using System.Linq;

public class Leaderboard : MonoBehaviour
{
    //Lien du tuto : https://www.youtube.com/watch?v=-O7zeq7xMLw
   [SerializeField] private List<TextMeshProUGUI> names;
    public List<TextMeshProUGUI> scores;


    public string publicLeaderboardKey = "6f8045ee6c564361e0e0ee2a631b7cce4d9128b2a49527b2dee21db6b740f4d0";

    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>
        {
            for (int i = 0; i < names.Count; ++i)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[1].Score.ToString();
            }
        }));
    }

    public int score;

    public void SetLeaderboardEntry(string username)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) => {
            
            GetLeaderboard();
        }));
    }
}
