using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    public Animator animator;
    public PlayerInput playerInput;
    public PlayerControl playerControl;
    public PlayerStateMachine PlayerStateMachine;

    protected float currentSpeed;
    public void Initialize(Animator animator, PlayerInput playerInput, PlayerControl playerControl, PlayerStateMachine PlayerStateMachine)
    {
        this.animator = animator;
        this.playerInput = playerInput;
        this.playerControl = playerControl;
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
