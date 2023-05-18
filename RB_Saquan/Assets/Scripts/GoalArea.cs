using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalArea : MonoBehaviour
{
    public Text MyText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        MyText.text = "" + score;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag ("Pickable"))
        {
            score = score + 1;
            coll.gameObject.SetActive(false);
        }
    }
}
