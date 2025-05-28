using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_idle", menuName = "Data/StateMachine/PlayerState/Idle")]
public class PlayerState_idle : PlayerState
{
    [SerializeField] protected float deceleration = 5f;//  ¼õËÙ¶È
    public override void Enter()
    {
        base.Enter();
        playerControl.SetVelocity(Vector2.zero);
        currentSpeed = playerControl.MoveSpeed;
    }
    public override void Update()
    {
        base.Update();
        if (playerInput.Jump)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_jump));
        }
        if (!playerControl.IsGrounded)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_fall));
        }
        if (playerInput.Move)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_run));
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);

    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.SetVelocityX(currentSpeed * playerControl.transform.localScale.x / 6f);
    }
}
