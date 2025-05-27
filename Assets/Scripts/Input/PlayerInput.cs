using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction PlayerInputAction;
    public bool Jump => PlayerInputAction.GamePlay.Jump.WasPressedThisFrame(); // 检测到跳跃
    public bool StopJump => PlayerInputAction.GamePlay.Jump.WasReleasedThisFrame(); // 检测到取消跳跃
    public bool HasJumpInputBuffer;
    public Vector2 Axes => PlayerInputAction.GamePlay.Axes.ReadValue<Vector2>(); //获取输入轴
    public float AxisX => Axes.x; // 获取x轴
    public bool Move => AxisX != 0f; //检测是否移动
    public void Awake()
    {
        PlayerInputAction = new PlayerInputAction();
    }
    private void OnEnable()
    {
        PlayerInputAction.GamePlay.Jump.canceled += delegate
        {
            HasJumpInputBuffer = false;
        };
    }
    private void OnGUI()
    {
        Rect rect = new Rect(10, 10, 200, 100);
        string message = "Has Jump Input Buff:" + HasJumpInputBuffer;
        GUIStyle style  = new GUIStyle();
        style.fontSize = 20;
        style.fontStyle = FontStyle.Bold;
        GUI.Label(rect, message, style);
    }
    public void EnableGamePlayInputs()
    {
        PlayerInputAction.GamePlay.Enable();//启用GamePlay输入
        Cursor.lockState = CursorLockMode.Locked;//隐藏鼠标
    }
}
