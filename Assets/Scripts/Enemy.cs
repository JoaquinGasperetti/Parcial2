using UnityEngine;

public class Enemy : TempleObject
{
    public int damage = 10;
    public float lifetime = 10f;

    private PlayerHealth playerHealth;
    private float timer = 0f;

    protected virtual void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        gameObject.AddComponent<EnemyMovement>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifetime)
        {
            Debug.Log("El enemigo se autodestruye por inactividad.");
            Destroy(gameObject);
        }
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
