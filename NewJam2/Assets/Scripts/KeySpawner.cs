using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject rust_key;  // Reference to the key prefab
    public List<Transform> spawnPoints;  // List of spawn points for the keys
    public int numberOfKeysToSpawn = 6;  // Number of keys you want to spawn

    void Start()
    {
        SpawnKeys();
    }

    void SpawnKeys()
    {
        // Create a list of indices for the spawn points
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            availableIndices.Add(i);
        }

        // Randomly select spawn points for the given number of keys
        for (int i = 0; i < numberOfKeysToSpawn; i++)
        {
            if (availableIndices.Count == 0)
            {
                Debug.LogWarning("Not enough spawn points available for all keys.");
                break;
            }

            // Get a random index from the available ones
            int randomIndex = Random.Range(0, availableIndices.Count);
            int spawnIndex = availableIndices[randomIndex];

            // Spawn the key at the selected spawn point
            Instantiate(rust_key, spawnPoints[spawnIndex].position, Quaternion.identity);

            // Remove the selected index so it's not used again
            availableIndices.RemoveAt(randomIndex);
        }
    }
}
