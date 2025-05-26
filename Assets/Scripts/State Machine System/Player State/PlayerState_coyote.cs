using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_coyote", menuName = "Data/StateMachine/PlayerState/CoyoteTime")]
public class PlayerState_coyote : PlayerState
{
    [SerializeField] protected float speed = 5f;
    [SerializeField] protected float coyeteTime = 0.1f;
    public override void Enter()
    {
        base.Enter();
        //animator.Play("Player_run");

        currentSpeed = playerControl.MoveSpeed;
    }
    public override void Update()
    {
        base.Update();
        if (playerInput.Jump)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_jump));
        }
        if (!playerInput.Move || stateDuration > coyeteTime)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_fall));
        }
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.Move(currentSpeed);
    }
}
