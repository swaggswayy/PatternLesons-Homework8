using UnityEngine;

[RequireComponent(typeof(Health))]
public class Death : MonoBehaviour
{
    private Health _health;

    public void Init()
    {
        _health = GetComponent<Health>();
        _health.Death += Die;
    }

    private void OnDestroy()
    {
        _health.Death -= Die;
    }

    private void Die()
    {
        Debug.Log("Die");
    }
}
