using System;
using UnityEngine;

public class CharacterLevel : MonoBehaviour
{
    [SerializeField] private int _level;

    public int Level => _level;

    public event Action<int> LevelChanged;

    public void Init()
    {
        LevelChanged?.Invoke(_level);
    }

    public bool TryRaisingLevel(int level)
    {
        if (level < 0) return false;

        _level += level;

        LevelChanged?.Invoke(_level);

        return true;
    }

    public void SetInitialValues(int initLevel)
    {
        _level = initLevel;
        LevelChanged?.Invoke(Level);
    }
}
