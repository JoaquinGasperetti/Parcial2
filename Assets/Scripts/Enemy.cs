using UnityEngine;

public class Enemy : TempleObject
{
    public int damage = 10;

    private PlayerHealth playerHealth;

    protected virtual void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        gameObject.AddComponent<EnemyMovement>();
    }


    public override void Interact()
    {
        Debug.Log("¡Un enemigo aparece!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
