using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnDelay = 3;
    public float maxSpawnDelay = 5;
    
    [Header("References")]
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay,maxSpawnDelay));
    }

    void OnDisable(){
        CancelInvoke();
    }

    void Spawn(){
        GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(randomObject, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay,maxSpawnDelay));
    }
}
