using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] BoxCollider2D _collider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.GetComponentInParent<IPickUp>();
        if(obj != null)
        {
            obj.OnPickUp();
        }
    }
}
