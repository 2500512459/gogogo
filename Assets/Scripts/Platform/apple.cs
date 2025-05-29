using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    [SerializeField] private float resetTime = 3f;  // 恢复时间
    private SpriteRenderer sprite;  // 获取SpriteRenderer组件
    private Collider2D col;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }
    // 检测玩家是否触发
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerControl>(out PlayerControl player))
        {
            player.CanAirJump  = true;
            sprite.enabled = false;
            col.enabled = false;
            StartCoroutine(ResetCoroutine());
        }
    }
    private void Reset()
    {
        sprite.enabled = true;
        col.enabled = true;
    }
    // 使用协程来恢复apple
    IEnumerator ResetCoroutine()
    {
        yield return new WaitForSeconds(resetTime);
        Reset();
    }
}
