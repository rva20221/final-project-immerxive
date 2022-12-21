using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = "" + score;
    }

    public void addScore()
    {
        score+= 10;
        ScoreText.text = "" + score;
    }

    public void minScore(){
        score-= 10;
        ScoreText.text = "" + score;
    }
}
