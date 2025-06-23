using UnityEngine;

public class HealthSystem
{
    private int health;
    private int maxHealth = 100;

    public int Health
    {
        get { return health; }
        set
        {
            if (value <= 0)
                health = 0;
            else if (value > maxHealth)
                health = maxHealth;
            else
                health = value;
        }
    }

    public bool IsDead()
    {
        return health <= 0;
    }
}
