using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_fall", menuName = "Data/StateMachine/PlayerState/Fall")]
public class PlayerState_fall : PlayerState
{
    [SerializeField] AnimationCurve speedCurve;
    [SerializeField] public float moveSpeed = 5f;
    public override void Update()
    {
        base.Update();
        if (playerControl.IsGrounded)
        {
            playerControl.SetVelocityZero();
            PlayerStateMachine.SwitchState(typeof(PlayerState_idle));
        }
        if (playerInput.Jump)
        {
            if (playerControl.CanAirJump)
            {
                PlayerStateMachine.SwitchState(typeof(PlayerState_airJump));
                return;
            }
            playerInput.HasJumpInputBuffer = true;
        }
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.SetVelocityY(speedCurve.Evaluate(stateDuration));
        playerControl.Move(moveSpeed);
    }
}
