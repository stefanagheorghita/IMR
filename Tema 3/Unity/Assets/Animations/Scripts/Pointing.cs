using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Pointing : MonoBehaviour
{

    [SerializeField] private GameObject hand1;
    [SerializeField] private GameObject hand2;
    private Animator hand1Animator;
    private Animator hand2Animator;
    void Start()
    {
        hand1Animator = hand1.GetComponent<Animator>();
        hand2Animator = hand2.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Target"))
        {

            hand1Animator.SetBool("isPointing", true);
            hand2Animator.SetBool("isPointing", true);
            StartCoroutine(ResetIsPointingAfterDelay(1f));
        }
    }

     IEnumerator ResetIsPointingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        hand1Animator.SetBool("isPointing", false);
        hand2Animator.SetBool("isPointing", false);
    }
    
}
