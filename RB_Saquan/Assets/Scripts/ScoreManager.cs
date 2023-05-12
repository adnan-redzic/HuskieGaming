using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text score;
    private int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void AddScre()
    {
        scoreAmount += 1;
    }
}
