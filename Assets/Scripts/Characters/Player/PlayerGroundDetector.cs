using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    [SerializeField] private float groundCheckDistance;
    public LayerMask groundLayer;
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - groundCheckDistance));
    }

    public bool IsGrounded() => Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);

}
