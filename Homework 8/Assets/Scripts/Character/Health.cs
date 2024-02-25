using System;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    public int CurrentHealth => _currentHealth;

    public event Action Death;
    public event Action<int> HealthChanged;

    public void Init()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke(_currentHealth);
    }

    public bool TryTakeDamage(int damage)
    {
        if (damage < 0 || _currentHealth <= 0)
            return false;

        _currentHealth -= damage;

        HealthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            Death?.Invoke();

        return true;
    }

    public void SetInitialValues(int initHealth)
    {
        _currentHealth = initHealth;
        HealthChanged?.Invoke(_currentHealth);
    }
}
