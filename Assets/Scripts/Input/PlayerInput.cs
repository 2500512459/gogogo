using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction PlayerInputAction;
    public bool Jump => PlayerInputAction.GamePlay.Jump.WasPressedThisFrame(); // ��⵽��Ծ
    public bool StopJump => PlayerInputAction.GamePlay.Jump.WasReleasedThisFrame(); // ��⵽ȡ����Ծ
    public bool HasJumpInputBuffer;
    public Vector2 Axes => PlayerInputAction.GamePlay.Axes.ReadValue<Vector2>(); //��ȡ������
    public float AxisX => Axes.x; // ��ȡx��
    public bool Move => AxisX != 0f; //����Ƿ��ƶ�
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
        PlayerInputAction.GamePlay.Enable();//����GamePlay����
        Cursor.lockState = CursorLockMode.Locked;//�������
    }
}
