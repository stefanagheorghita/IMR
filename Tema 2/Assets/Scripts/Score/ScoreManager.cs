using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    private Coroutine coroutine;

    public void SetScore(int newScore)
    {
        score = newScore;
    }

    void Start()
    {
        scoreText.text = "Start Game!";
        StartCoroutine(HideScoreAfterDelay(0.3f));
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString() + " POINTS";
         if(coroutine != null)
        {
            StopCoroutine(coroutine);
        }

        coroutine = StartCoroutine(HideScoreAfterDelay(2f));
    }

    private IEnumerator HideScoreAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        scoreText.text = "";
    }
}
