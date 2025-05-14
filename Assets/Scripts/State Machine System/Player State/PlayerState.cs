using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    public Animator animator;
    public StateMachine PlayerStateMachine;

    public void Initialize(Animator animator, StateMachine PlayerStateMachine)
    {
        this.animator = animator;
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
