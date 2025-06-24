using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public int amountToSpawn = 10;
    public float minDistance = 10f;
    public float maxDistance = 20f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        for (int i = 0; i < amountToSpawn; i++)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        GameObject obj = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        float distance = Random.Range(minDistance, maxDistance);

        Vector3 spawnPos = player.position + (Vector3)(randomDirection * distance);

        Instantiate(obj, spawnPos, Quaternion.identity);
    }
}
