using UnityEngine;

public class Chest : TempleObject
{
    public bool isOpen = false;
    public int goldAmount = 10;

    private PlayerInventory playerInventory;

    void Start()
    {
        playerInventory = GameObject.FindWithTag("Player").GetComponent<PlayerInventory>();
    }

    public override void Interact()
    {
        if (!isOpen)
        {
            isOpen = true;
            playerInventory.AddGold(goldAmount);
            Debug.Log("Cofre abierto, oro añadido: " + goldAmount);
        }
        else
        {
            Debug.Log("Cofre ya abierto");
        }
    }
}
