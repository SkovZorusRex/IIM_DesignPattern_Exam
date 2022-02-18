using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    [SerializeField] PlayerEntity _player;
    //[SerializeField] TextMeshProUGUI _text;
    [SerializeField] Slider _slider;
 
    void UpdateDisplayedHealth(int _)
    {
        //_text.text = _player.Health.CurrentHealth.ToString();
        _slider.value = (float)_player.Health.CurrentHealth / (float)_player.Health.MaxHealth; //Conversion en float entre 0 et 1
    }
    

    private void Start()
    {
        _player.Health.OnDamage += UpdateDisplayedHealth;

    }

    private void OnDestroy()
    {
        _player.Health.OnDamage -= UpdateDisplayedHealth;
    }

    private void _player_OnHealthChanged(int obj)
    {
        UpdateDisplayedHealth(obj);
    }
}
