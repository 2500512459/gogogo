using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_run", menuName = "Data/StateMachine/PlayerState/Run")]
public class PlayerState_run : PlayerState
{
    public override void Enter()
    {
        base.Enter();
        animator.Play("Player_run");
    }
    public override void Update()
    {
        base.Update();
        if(!playerInput.Move)
            PlayerStateMachine.SwitchState(typeof(PlayerState_idle));
    }
}
