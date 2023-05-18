using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        ScoreAmount = 0;
        MyScoreText.text = "" + ScoreAmount;
    }

    private void OnTriggerEnter2D(Collider2D jackson)
    {
        if (jackson.tag == "Objective")
        {
            ScoreAmount += 1;
            MyScoreText.text = "" + ScoreAmount;
            Debug.Log("Works");
            Destroy(jackson.gameObject);
        }
    }
}
