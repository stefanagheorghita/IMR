using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{

    public bool exists;

    public void onScreen()
    {
        exists = true;
    }

    public void notOnScreen()
    {
        exists = false;
    }

}