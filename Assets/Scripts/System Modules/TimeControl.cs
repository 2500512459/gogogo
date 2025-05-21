using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [Range(0f, 2f)]public float defaultTimeScale = 1f; //��ϷĬ��ʱ��

    [Range(0f, 2f)]public float bulletTimeScale = 0f; //�ӵ�ʱ��

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
