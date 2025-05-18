using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : StateMachine
{
    protected Animator animator;
    protected PlayerInput playerInput;
    [SerializeField] private PlayerState[] states;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
        stateTables = new Dictionary<System.Type, IState>(states.Length);
        //  Initialize the state
        foreach (PlayerState state in states)
        {
            state.Initialize(animator, playerInput, this);
            stateTables.Add(state.GetType(), state);
        }
    }

    private void Start()
    {
        //  Set the initial state
        SwitchOn(stateTables[typeof(PlayerState_idle)]);
    }
}
