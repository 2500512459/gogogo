using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_jump", menuName = "Data/StateMachine/PlayerState/Jump")]
public class PlayerState_jump : PlayerState
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] public float moveSpeed = 5f;

    [SerializeField] private float minJumpDuration = 0.1f; // 新增最小持续时间
    public override void Enter()
    {
        base.Enter();
        playerControl.SetVelocityY(jumpForce);
        playerInput.HasJumpInputBuffer = false;
    }
    public override void Update()
    {
        if(stateDuration < minJumpDuration) 
            return;
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
