using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    public void SetScore(int newScore)
    {
        score = newScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";

    }

    // Update is called once per frame
    public void UpdateScoreText()
    {
        scoreText.text = score.ToString() + " POINTS";
    }
}
