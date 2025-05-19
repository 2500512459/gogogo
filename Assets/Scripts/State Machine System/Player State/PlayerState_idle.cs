using UnityEngine;

[CreateAssetMenu(fileName = "PlayerState_idle", menuName = "Data/StateMachine/PlayerState/Idle")]
public class PlayerState_idle : PlayerState
{
    [SerializeField] protected float deceleration = 5f;
    public override void Enter()
    {
        base.Enter();
        animator.Play("Player_idle");

        currentSpeed = playerControl.MoveSpeed;
    }
    public override void Update()
    {
        base.Update();
        if(playerInput.Move)
            PlayerStateMachine.SwitchState(typeof(PlayerState_run));
        currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        playerControl.SetVelocityX(currentSpeed * playerControl.transform.localScale.x / 6f);
    }
}
