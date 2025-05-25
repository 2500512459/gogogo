using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    [SerializeField] private float resetTime = 3f;
    private SpriteRenderer sprite;
    private Collider2D col;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }
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

    IEnumerator ResetCoroutine()
    {
        yield return new WaitForSeconds(resetTime);
        Reset();
    }
}
