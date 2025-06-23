using UnityEngine;

public class Chest : TempleObject
{
    public bool isOpen = false;

    public override void Interact()
    {
        if (!isOpen)
        {
            Debug.Log("Cofre abierto");
            isOpen = true;
        }
        else
        {
            Debug.Log("Ya estaba abierto");
        }
    }
}

public class GoldChest : Chest
{
    public override void Interact()
    {
        base.Interact();
        if (!isOpen) Debug.Log("¡Encontraste oro!");
    }
}
