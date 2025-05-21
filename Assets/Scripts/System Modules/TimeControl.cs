using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [Range(0f, 2f)]public float defaultTimeScale = 1f; //游戏默认时间

    [Range(0f, 2f)]public float bulletTimeScale = 0f; //子弹时间

    private void Awake()
    {
        Time.timeScale = defaultTimeScale;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == defaultTimeScale)
            {
                Time.timeScale = bulletTimeScale;
            }
            else
            {
                Time.timeScale = defaultTimeScale;
            }
        }
    }
}
