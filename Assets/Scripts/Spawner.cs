using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    void Start()
    {
        foreach (GameObject prefab in prefabsToSpawn)
        {
            Instantiate(prefab, new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f)), Quaternion.identity);
        }
    }
}
