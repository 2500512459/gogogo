using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5;
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            float x = Input.GetAxisRaw("Horizontal");
            Debug.Log(x);
            if (x == 1)
            {
                spriteRenderer.flipX = false;
            }
            else
            {
                //·­×ª
                spriteRenderer.flipX  = true;
            }
            transform.position = new Vector3(transform.position.x + x * speed * Time.deltaTime, transform.position.y, transform.position.z);
            anim.Play("Player_run");
        }
        else
        {
            anim.Play("Player_idle");
        }
    }
}
