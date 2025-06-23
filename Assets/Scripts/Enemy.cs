using UnityEngine;

public class Enemy : TempleObject
{
    public override void Interact()
    {
        Debug.Log("¡Un enemigo aparece!");
    }
}

public class MimicEnemy : Enemy
{
    public override void Interact()
    {
        Debug.Log("¡Era un cofre trampa!");
    }
}
