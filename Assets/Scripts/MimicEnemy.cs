using UnityEngine;

public class MimicEnemy : Enemy
{
    private bool isMimic = true;
    private float fleeDistance = 3f;
    private float fleeSpeed = 3f;
    private Transform player;

    protected override void Start()
    {
        base.Start();
        player = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        if (isMimic)
        {
            
            Vector3 dir = (transform.position - player.position).normalized;
            transform.position += dir * fleeSpeed * Time.deltaTime;
          
            if (Vector3.Distance(transform.position, player.position) > fleeDistance)
            {
                isMimic = false;
            }
        }
        else
        {            
            base.GetComponent<EnemyMovement>().enabled = true;
        }
    }

    public override void Interact()
    {
        if (isMimic)
        {
            Debug.Log("¡Era un cofre trampa!");
            var movement = GetComponent<EnemyMovement>();
            if (movement != null)
                movement.enabled = false;
        }
        else
        {
            base.Interact();
        }
    }
}
