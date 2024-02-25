using UnityEngine;
using UnityEngine.UI;

public class DamageSimulation : MonoBehaviour
{
    [SerializeField] Button _damageButton;
    [SerializeField] Health _damageable;
    [SerializeField] int _damage;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(DoDamage);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(DoDamage);
    }

    private void DoDamage()
    {
        _damageable.TryTakeDamage(_damage);
    }
}
