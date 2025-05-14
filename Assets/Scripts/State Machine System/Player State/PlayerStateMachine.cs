using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        //  Initialize the state
    }
}
