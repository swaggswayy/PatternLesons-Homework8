using UnityEngine;
using UnityEngine.UI;

public class LevelUpSimulation : MonoBehaviour
{
    [SerializeField] private Button _levelButton;
    [SerializeField] private CharacterLevel _level;
    [SerializeField] private int _numberLevelsToAdd;

    private void OnEnable()
    {
        _levelButton.onClick.AddListener(AddLevels);
    }

    private void OnDisable()
    {
        _levelButton.onClick.RemoveListener(AddLevels);
    }

    private void AddLevels()
    {
        _level.TryRaisingLevel(_numberLevelsToAdd);
    }
}
