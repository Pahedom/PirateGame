using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth;

    public Slider display;

    private float _health;

    public Action OnDie;

    private void Start()
    {
        _health = maxHealth;

        display.maxValue = maxHealth;
        UpdateDisplay();
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0f)
        {
            OnDie?.Invoke();

            Destroy(gameObject);
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        display.value = _health;
    }
}