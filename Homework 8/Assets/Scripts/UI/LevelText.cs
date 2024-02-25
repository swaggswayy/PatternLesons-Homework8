using TMPro;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;

    public void SetLevel(int level)
    {
        _levelText.text = level.ToString();
    }
}
