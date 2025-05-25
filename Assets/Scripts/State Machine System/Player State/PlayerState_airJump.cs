using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_airJump", menuName = "Data/StateMachine/PlayerState/AirJump")]
public class PlayerState_airJump : PlayerState
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] public float moveSpeed = 5f;
    public override void Enter()
    {
        base.Enter();
        playerControl.CanAirJump  = false;
        playerControl.SetVelocityY(jumpForce);
    }
    public override void Update()
    {
        if (playerControl.IsFall || playerInput.StopJump)
            PlayerStateMachine.SwitchState(typeof(PlayerState_fall));
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.Move(moveSpeed);
    }
}
