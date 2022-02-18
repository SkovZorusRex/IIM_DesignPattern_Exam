using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Potion : MonoBehaviour, IPickUp
{
    [SerializeField] int _amount;
    [SerializeField] PlayerReference _PlayerReference;

    public void OnPickUp()
    {
        _PlayerReference.Instance.Health.Heal(_amount);
        this.gameObject.SetActive(false);
    }
}
