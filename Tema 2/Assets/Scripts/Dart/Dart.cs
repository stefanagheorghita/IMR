using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart : MonoBehaviour
{
    private Vector3 throwPosition;
    private Vector3 collisionPosition;

    public ScoreCalculator scoreCalculator;
    public ScoreManager scoreManager;
    private int score = 0;


    public void SetThrowPosition(Vector3 position)
    {
        throwPosition = position;
    }

    public Vector3 GetThrowPosition()
    {
        return throwPosition;
    }

    public void SetCollisionPosition(Vector3 position)
    {
        collisionPosition = position;
    }

    public Vector3 GetCollisionPosition()
    {
        return collisionPosition;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Target"))
        {
            collisionPosition = collision.contacts[0].point;
            score = scoreCalculator.CalculateScore(throwPosition, collisionPosition);
            scoreManager.SetScore(score);
            scoreManager.UpdateScoreText();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("Target"))
        {
            
        }
    }
}
