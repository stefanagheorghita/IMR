using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Grabing : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject hand;
    private Animator handAnimator;
    void Start()
    {
        handAnimator = hand.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
           handAnimator.SetBool("isGrabing", true);
        }
        else if(Input.GetKeyUp(KeyCode.G))
        {
            handAnimator.SetBool("isGrabing", false);
        }
    }
}
