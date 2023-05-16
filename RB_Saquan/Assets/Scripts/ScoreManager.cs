using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text score;
    private int scoreAmount;

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.name == "Saquon")
        {
            scoreAmount += 1;
            score.text = scoreAmount.ToString();
        }
    }
}
