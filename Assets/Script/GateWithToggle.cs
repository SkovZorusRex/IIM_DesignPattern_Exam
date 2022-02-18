using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWithToggle : MonoBehaviour
{
    [SerializeField] int _nbToggleToOpen; //nombre de Toggle nécessaire pour ouvrir la porte
    private int _nbToggleOn; //nombre de Toggle en position ON

    public void AddToggleState()
    {
        _nbToggleOn++;
        if(_nbToggleOn == _nbToggleToOpen) //Tout les Toggles sont ON, ouverture de la Porte
            gameObject.SetActive(false);
    }
    public void RemoveToggleState()
    {
        _nbToggleOn--;
        if (_nbToggleOn <= 0)
            _nbToggleOn = 0;
    }
}
