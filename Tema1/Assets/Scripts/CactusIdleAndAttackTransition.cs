using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusIdleAndAttackTransition : MonoBehaviour
{
    [SerializeField] private GameObject firstCactus;
    [SerializeField] private GameObject secondCactus;

    private State firstCactusState;
    private State secondCactusState;
    private Animator firstCactusAnimator;
    private Animator secondCactusAnimator;
    public float distance;

    void Start()
    {
        firstCactusState = firstCactus.GetComponent<State>();
        secondCactusState = secondCactus.GetComponent<State>();
        firstCactusAnimator = firstCactus.GetComponent<Animator>();
        secondCactusAnimator = secondCactus.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (firstCactusState.exists && secondCactusState.exists)
        {
            attack();
        }
    }

    public void attack()
    {
        distance = Vector3.Distance(firstCactus.transform.position, secondCactus.transform.position);
        if (distance <= 25.0f)
        {
            firstCactusAnimator.SetBool("Attack", true);
        }
        else
        {
            firstCactusAnimator.SetBool("Attack", false);
        }
    }
}







/**public class CactusIdleAndAttackTransition : StateMachineBehaviour
{
   // private Animator animator;
   // private findOtherCactus otherCactus;
   void Start()
   {
       // animator = GetComponent<Animator>();
   }
   
   void Update()
   {
       // otherCactus = GameObject.FindObjectOfType<findOtherCactus>();
   }
}**/
