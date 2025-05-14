using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5;
    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            float x = Input.GetAxisRaw("Horizontal");
            Debug.Log(x);
            transform.position  = new Vector3(transform.position.x + x * speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
