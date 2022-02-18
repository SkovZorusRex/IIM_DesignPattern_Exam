using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Potion : MonoBehaviour, IPickUp
{
    [SerializeField] int _amount; //Quantit� de vie rendu
    [SerializeField] PlayerReference _PlayerReference; //R�ference vers le Player, servant lors de la cr�ation par une caisse

    //Appeler lors de la collision avec le joueur
    public void OnPickUp()
    {
        _PlayerReference.Instance.Health.Heal(_amount);
        this.gameObject.SetActive(false);
    }
}
