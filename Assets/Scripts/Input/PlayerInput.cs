using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public PlayerInputAction PlayerInputAction;
    public bool Jump => PlayerInputAction.GamePlay.Jump.WasPressedThisFrame();
    public bool StopJump => PlayerInputAction.GamePlay.Jump.WasReleasedThisFrame();
    public Vector2 Axes => PlayerInputAction.GamePlay.Axes.ReadValue<Vector2>();
    public float AxisX => Axes.x;
    public float AxisY => Axes.y;
    public bool Move => AxisX != 0f;
    public void Awake()
    {
        PlayerInputAction = new PlayerInputAction();
    }
    public void EnableGamePlayInputs()
    {
        PlayerInputAction.GamePlay.Enable();//∆Ù”√GamePlay ‰»Î
        Cursor.lockState = CursorLockMode.Locked;//“˛≤ÿ Û±Í
    }
}
