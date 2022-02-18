using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntityShield : MonoBehaviour
{
    [SerializeField] UnityEvent _OnShieldUp;
    [SerializeField] UnityEvent _OnShieldDown;

    public void ShieldUp()
    {
        _OnShieldUp.Invoke();
    }

    public void ShieldDown()
    {
        _OnShieldDown.Invoke();
    }
}
