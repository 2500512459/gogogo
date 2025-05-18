using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_idle", menuName = "Data/StateMachine/PlayerState/Idle")]
public class PlayerState_idle : PlayerState
{
    public override void Enter()
    {
        base.Enter();
        animator.Play("Player_idle");
    }
    public override void Update()
    {
        base.Update();
        if(playerInput.Move)
            PlayerStateMachine.SwitchState(typeof(PlayerState_run));
    }
}
