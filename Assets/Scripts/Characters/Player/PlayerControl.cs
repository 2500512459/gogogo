using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private PlayerInput playerInput;    // 输入
    private PlayerGroundDetector groundDetector; // 检测是否在地面上
    public Rigidbody2D rb; //  刚体
    public float MoveSpeed => Mathf.Abs(rb.velocity.x); //  移动速度
    public bool CanAirJump = true;
    private void Awake()
    {
        groundDetector = GetComponentInChildren<PlayerGroundDetector>();
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        playerInput.EnableGamePlayInputs();
    }

    public void Move(float speed)
    {
        if (playerInput.Move)
        {
            transform.localScale = new Vector3(playerInput.Axes.x * 6f, transform.localScale.y, transform.localScale.z);
        }
        SetVelocityX(speed * playerInput.Axes.x);
    }
    public void SetVelocityX(float speed)
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    public void SetVelocityY(float speed)
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }
    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }
    public void SetVelocity(Vector2 vector2)
    {
        rb.velocity = vector2;
    }

    public bool IsGrounded => groundDetector.IsGrounded();  // 是否在地面上
    public bool IsFall => rb.velocity.y < 0 && !IsGrounded; // 是否掉落
}
