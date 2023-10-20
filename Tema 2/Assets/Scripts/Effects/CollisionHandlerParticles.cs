using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandlerParticles : MonoBehaviour
{
  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Dart"))
        {
            ParticleSystem particleSystem = GetComponent<ParticleSystem>();
            particleSystem.Play();

        }
    }
}
