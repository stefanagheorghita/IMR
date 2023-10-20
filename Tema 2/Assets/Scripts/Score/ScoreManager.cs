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

    void Start()
    {
        scoreText.text = "Start Game!";
        StartCoroutine(HideScoreAfterDelay(0.3f));
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString() + " POINTS";
        StartCoroutine(HideScoreAfterDelay(2f));
    }

    private IEnumerator HideScoreAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Așteaptă pentru o anumită perioadă de timp

        // După perioada de așteptare, ascunde textul
        scoreText.text = "";
    }
}
