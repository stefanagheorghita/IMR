using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    private int score = 0;


    public int CalculateScore(Vector3 throwPosition, Vector3 collisionPosition)
    {
        float distance = Vector3.Distance(throwPosition, collisionPosition);
        score = score + Mathf.RoundToInt(distance);

        return score;
    }


}
