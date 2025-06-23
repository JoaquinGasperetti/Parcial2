using UnityEngine;
using System;


public class HealthSystem
{
    private int health;
    private int maxHealth = 100;

    public event Action<int> OnHealthChanged;

    public int Health
    {
        get => health;
        set
        {
            if (value <= 0)
                health = 0;
            else if (value > maxHealth)
                health = maxHealth;
            else
                health = value;

            OnHealthChanged?.Invoke(health);
        }
    }

    public HealthSystem(int maxHealth = 100)
    {
        this.maxHealth = maxHealth;
        health = maxHealth;
    }

    public bool IsDead()
    {
        return health <= 0;
    }
}
