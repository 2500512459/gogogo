using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class banana : MonoBehaviour
{
    public ObjectEventSO TirggerBanana;
    // ºÏ≤‚ÕÊº“ «∑Ò¥•∑¢
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerControl>(out PlayerControl player))
        {
            TirggerBanana.RaiseEvent(this, this);
            Destroy(gameObject);
        }
    }
}
