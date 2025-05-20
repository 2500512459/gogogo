using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction PlayerInputAction;
    public bool Jump => PlayerInputAction.GamePlay.Jump.WasPressedThisFrame(); // ��⵽��Ծ
    public bool StopJump => PlayerInputAction.GamePlay.Jump.WasReleasedThisFrame(); // ��⵽ȡ����Ծ
    public Vector2 Axes => PlayerInputAction.GamePlay.Axes.ReadValue<Vector2>(); //��ȡ������
    public float AxisX => Axes.x; // ��ȡx��
    public float AxisY => Axes.y; //  ��ȡy��
    public bool Move => AxisX != 0f; //����Ƿ��ƶ�
    public void Awake()
    {
        PlayerInputAction = new PlayerInputAction();
    }
    public void EnableGamePlayInputs()
    {
        PlayerInputAction.GamePlay.Enable();//����GamePlay����
        Cursor.lockState = CursorLockMode.Locked;//�������
    }
}
