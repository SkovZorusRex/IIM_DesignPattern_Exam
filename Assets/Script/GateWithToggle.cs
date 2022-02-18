using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWithToggle : MonoBehaviour
{
    [SerializeField] int _nbToggleToOpen;
    private int _nbToggleOn;

    public void AddToggleState()
    {
        _nbToggleOn++;
        if(_nbToggleOn == _nbToggleToOpen)
            gameObject.SetActive(false);
    }
    public void RemoveToggleState()
    {
        _nbToggleOn--;
        if (_nbToggleOn <= 0)
            _nbToggleOn = 0;
    }
}
