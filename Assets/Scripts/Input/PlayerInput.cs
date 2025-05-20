using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction PlayerInputAction;
    public bool Jump => PlayerInputAction.GamePlay.Jump.WasPressedThisFrame(); // 检测到跳跃
    public bool StopJump => PlayerInputAction.GamePlay.Jump.WasReleasedThisFrame(); // 检测到取消跳跃
    public Vector2 Axes => PlayerInputAction.GamePlay.Axes.ReadValue<Vector2>(); //获取输入轴
    public float AxisX => Axes.x; // 获取x轴
    public float AxisY => Axes.y; //  获取y轴
    public bool Move => AxisX != 0f; //检测是否移动
    public void Awake()
    {
        PlayerInputAction = new PlayerInputAction();
    }
    public void EnableGamePlayInputs()
    {
        PlayerInputAction.GamePlay.Enable();//启用GamePlay输入
        Cursor.lockState = CursorLockMode.Locked;//隐藏鼠标
    }
}
