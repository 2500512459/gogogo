using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    public Animator animator;
    public PlayerStateMachine PlayerStateMachine;
    public PlayerInput playerInput;
    public void Initialize(Animator animator, PlayerInput playerInput, PlayerStateMachine PlayerStateMachine)
    {
        this.animator = animator;
        this.playerInput = playerInput;
        this.PlayerStateMachine = PlayerStateMachine;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }

    public virtual void FixedUpdate()
    {
        
    }

    public virtual void Update()
    {
        
    }
}
