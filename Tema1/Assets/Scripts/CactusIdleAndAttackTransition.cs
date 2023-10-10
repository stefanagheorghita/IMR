using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusIdleAndAttackTransition : MonoBehaviour
{
    [SerializeField] private GameObject firstCactus;
    [SerializeField] private GameObject secondCactus;

    private Animator firstCactusAnimator;
    private Animator secondCactusAnimator;
    public float distance;

    void Start()
    {
        firstCactusAnimator = firstCactus.GetComponent<Animator>();
        secondCactusAnimator = secondCactus.GetComponent<Animator>();
    }

    
    void Update()
    {
        distance = Vector3.Distance(firstCactus.transform.position, secondCactus.transform.position);
        if (distance <= 0.25f)
        {
            firstCactusAnimator.SetBool("isAttacking", true);
            secondCactusAnimator.SetBool("isAttacking", true);

        }
        else
        {
            firstCactusAnimator.SetBool("isAttacking", false);
            secondCactusAnimator.SetBool("isAttacking", false);

        }
    }
        
}



