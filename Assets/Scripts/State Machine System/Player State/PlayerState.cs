using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    protected Animator animator;
    protected PlayerInput playerInput;
    protected PlayerControl playerControl;
    protected PlayerStateMachine PlayerStateMachine;

    protected float currentSpeed;
    protected float stateStartTime;
    protected float stateDuration => Time.time - stateStartTime;
    protected bool isAnimationFinished => stateDuration >= animator.GetCurrentAnimatorStateInfo(0).length;
    

    [SerializeField] private string stateName;
    [SerializeField, Range(0, 1)] private float transitionDuration = 0.1f;//过度时间
    private int stateHash;
    public void Initialize(Animator animator, PlayerInput playerInput, PlayerControl playerControl, PlayerStateMachine PlayerStateMachine)
    {
        this.animator = animator;
        this.playerInput = playerInput;
        this.playerControl = playerControl;
        this.PlayerStateMachine = PlayerStateMachine;
    }

    private void OnEnable()
    {
        stateHash = Animator.StringToHash(stateName);
    }

    public virtual void Enter()
    {
        animator.CrossFade(stateHash, transitionDuration);// 动画平滑过渡
        stateStartTime = Time.time;
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
