using UnityEngine;

public class Trap : TempleObject
{
    public GameObject mimicPrefab;

    public override void Interact()
    {
        Debug.Log("¡Caíste en una trampa!");

        if (mimicPrefab != null)
        {
            Instantiate(mimicPrefab, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
