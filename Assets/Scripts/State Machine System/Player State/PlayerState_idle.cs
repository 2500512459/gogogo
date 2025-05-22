using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_idle", menuName = "Data/StateMachine/PlayerState/Idle")]
public class PlayerState_idle : PlayerState
{
    [SerializeField] protected float deceleration = 5f;//  ¼õËÙ¶È
    public override void Enter()
    {
        base.Enter();
        //animator.Play("Player_idle");

        currentSpeed = playerControl.MoveSpeed;
    }
    public override void Update()
    {
        base.Update();
        if (playerInput.Jump)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_jump));
        }
        if (playerInput.Move)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_run));
        }
        if (!playerControl.IsGrounded)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_fall));
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);

    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.SetVelocityX(currentSpeed * playerControl.transform.localScale.x / 6f);
    }
}
