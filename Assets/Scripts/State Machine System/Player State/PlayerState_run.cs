using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_run", menuName = "Data/StateMachine/PlayerState/Run")]
public class PlayerState_run : PlayerState
{
    [SerializeField] protected float speed = 5f;
    [SerializeField] protected float acceleration = 20f;
    public override void Enter()
    {
        base.Enter();
        animator.Play("Player_run");
        currentSpeed = playerControl.MoveSpeed;
    }
    public override void Update()
    {
        base.Update();
        if (!playerInput.Move)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_idle));
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, speed, acceleration * Time.deltaTime);
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.Move(currentSpeed);
    }
}
