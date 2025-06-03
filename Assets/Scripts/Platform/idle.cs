using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void fall()
    {
        rb.gravityScale = 1;
    }
}
