using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public string[] allowedColors;
    ScoreManager sm;
    Score score;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            Gem gem = other.GetComponent<Gem>();
            if (gem != null && IsColorAllowed(gem.color))
            {
                sm.AddScore(score);
            }
            Destroy(other.gameObject);
            sm.AddScore(score);
        }
    }

    bool IsColorAllowed(string gemColor)
    {
        foreach (string allowedColor in allowedColors)
        {
            if (gemColor == allowedColor)
            {
                return true;
            }
        }
        return false;
    }
}
