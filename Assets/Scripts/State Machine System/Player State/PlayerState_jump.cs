using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_jump", menuName = "Data/StateMachine/PlayerState/Jump")]
public class PlayerState_jump : PlayerState
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] public float moveSpeed = 5f;
    public override void Enter()
    {
        base.Enter();
        playerControl.SetVelocityY(jumpForce);
        playerInput.HasJumpInputBuffer = false;
    }
    public override void Update()
    {
        if (playerControl.IsFall || playerInput.StopJump)
        {
            PlayerStateMachine.SwitchState(typeof(PlayerState_fall));
        }
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.Move(moveSpeed);
    }
}
