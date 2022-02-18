using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntityShield : MonoBehaviour
{
    [SerializeField] UnityEvent _OnShieldUp; //Evenements qui permet de d�finir ce qu'il se passe lorsque le bouclier est lev�
    [SerializeField] UnityEvent _OnShieldDown; //Evenements permettant de d�finir ce qu'il se passe lorsque l'on baisse le bouclier

    public void ShieldUp()
    {
        _OnShieldUp.Invoke();
    }

    public void ShieldDown()
    {
        _OnShieldDown.Invoke();
    }
}
