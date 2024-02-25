using System;
using UnityEngine;

public class CharacterMediator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private CharacterLevel _level;
    [SerializeField] private HealthText _healthText;
    [SerializeField] private LevelText _levelText;
    [SerializeField] private RestartPanel _restartPanel;

    public void Init()
    {
        _health.HealthChanged += OnHealthChanged;
        _health.Death += OnDeath;
        _level.LevelChanged += OnLevelChanged;
        _restartPanel.RestartScene += OnRestart;
    }

    private void OnDestroy()
    {
        _health.HealthChanged -= OnHealthChanged;
        _health.Death -= OnDeath;
        _level.LevelChanged -= OnLevelChanged;
    }

    private void OnRestart(CharacterData characterData)
    {
        _health.SetInitialValues(characterData.InitialHealth);
        _level.SetInitialValues(characterData.InitialLevel);
    }

    private void OnHealthChanged(int health)
    {
        _healthText.SetHealth(health);
    }   
    
    private void OnDeath()
    {
        _restartPanel.Show();
    }
    private void OnLevelChanged(int level)
    {
        _levelText.SetLevel(level);
    }
}
