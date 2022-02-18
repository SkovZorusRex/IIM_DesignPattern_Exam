using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour, IPickUp
{
    [SerializeField] UnityEvent _OnPickUp; //Actions effectu�s lors du pickup

    //Appeler lors de la collision avec le joueur
    public void OnPickUp()
    {
        _OnPickUp.Invoke();
    }
}
