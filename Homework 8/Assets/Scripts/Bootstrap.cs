using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Death _death;
    [SerializeField] private CharacterLevel _level;
    [SerializeField] private CharacterMediator _characterMediator;
    [SerializeField] private CharacterData _characterData;
    [SerializeField] private RestartPanel _restartPanel;

    private void Awake()
    {
        _characterMediator.Init();
        _health.Init();
        _death.Init();
        _level.Init();
        _characterData = new CharacterData(_health.CurrentHealth, _level.Level);
        _restartPanel.Init(_characterData);
    }
}
