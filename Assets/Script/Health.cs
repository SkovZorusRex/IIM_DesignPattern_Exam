using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IHealth
{
    // Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _maxHealth;
    [SerializeField] bool canTakeDamage = true;
    [SerializeField] UnityEvent _onDeath;
    [SerializeField] ControlShakeReference _shakeReference;
  

    // Propriétés
    public int CurrentHealth { get; private set; }
    public int MaxHealth => _maxHealth;
    public bool IsDead => CurrentHealth <= 0;

    // Events
    public event UnityAction OnSpawn;
    public event UnityAction<int> OnDamage;
    public event UnityAction OnDeath { add => _onDeath.AddListener(value); remove => _onDeath.RemoveListener(value); }

    // Methods
    void Awake() => Init();

    void Init()
    {
        CurrentHealth = _startHealth;
        canTakeDamage = true;
        OnSpawn?.Invoke();
    }

    public void Heal(int amount)
    {
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");

        var tmp = CurrentHealth;
        CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);
        var delta = CurrentHealth + tmp;
        //OnHeal?.Invoke(delta);
    }
    public void TakeDamage(int amount)
    {
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");


        if (canTakeDamage)
        {
            var tmp = CurrentHealth;
            CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
            var delta = CurrentHealth - tmp;
            OnDamage?.Invoke(delta);
            _shakeReference?.Instance.LaunchScreenShake();

            if (CurrentHealth <= 0)
            {
                _onDeath?.Invoke();
            } 
        }

    }

    public void CanTakeDamage(bool state)
    {
        canTakeDamage = state;
    }

    [Button("test")]
    void MaFonction()
    {
        var enumerator = MesIntPrefere();

        while(enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }
    }


    List<IEnumerator> _coroutines;

    IEnumerator<int> MesIntPrefere()
    {

        //

        var age = 12;

        yield return 12;


        //

        yield return 3712;

        age++;
        //

        yield return 0;



        //
        yield break;
    }





}
