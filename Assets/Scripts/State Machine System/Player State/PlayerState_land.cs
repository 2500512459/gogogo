using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_land", menuName = "Data/StateMachine/PlayerState/Land")]
public class PlayerState_land : PlayerState
{
    [SerializeField] protected float stiffTime = 0.2f;
    public override void Enter()
    {
        base.Enter();
        playerControl.SetVelocity(Vector2.zero);
        playerControl.CanAirJump = true;
    }
    public override void Update()
    {
        base.Update();
        if (playerInput.HasJumpInputBuffer || playerInput.Jump)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_jump));
        }
        if (stateDuration < stiffTime)
        {
            return;
        }
        if (playerInput.Move)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_run));
        }
        if (isAnimationFinished)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_idle));
        }

    }
}
