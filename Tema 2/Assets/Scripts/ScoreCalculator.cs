using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
   public int CalculateScore(Vector3 throwPosition, Vector3 collisionPosition)
   {
     float distance = Vector3.Distance(throwPosition, collisionPosition);

     return Mathf.RoundToInt(distance);
   }
   
}
