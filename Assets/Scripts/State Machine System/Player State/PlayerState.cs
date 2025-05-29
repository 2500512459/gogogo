using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    protected Animator animator;
    protected PlayerInput playerInput;
    protected PlayerControl playerControl;
    protected PlayerStateMachine PlayerStateMachine;

    protected float currentSpeed;   //当前移动速度
    protected float stateStartTime; //当前状态开始时间
    protected float stateDuration => Time.time - stateStartTime;    //当前状态持续时间
    protected bool isAnimationFinished => stateDuration >= animator.GetCurrentAnimatorStateInfo(0).length;  //当前动画是否播放完毕
    

    [SerializeField] private string stateName;  // 状态名称
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
        stateHash = Animator.StringToHash(stateName);   // 获取状态的哈希值，将状态名称转换为哈希值
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
