using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;

    public void SetHealth(int health)
    {
        _healthText.text = health.ToString();
    }
}
