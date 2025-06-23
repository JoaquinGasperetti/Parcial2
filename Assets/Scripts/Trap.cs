using UnityEngine;

public class Trap : TempleObject
{
    public override void Interact()
    {
        Debug.Log("¡Caíste en una trampa!");
    }
}
