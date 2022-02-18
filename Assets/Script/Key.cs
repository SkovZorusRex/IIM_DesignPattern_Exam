using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour, IPickUp
{
    [SerializeField] UnityEvent _OnPickUp;
    public void OnPickUp()
    {
        _OnPickUp.Invoke();
    }
}
