using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorTrigger : MonoBehaviour
{
    public KeyCollection playerKeyCollector; // Reference to the player's key collector script

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided with the door is the player
        if (other.CompareTag("Player"))
        {
            // Check if the player has collected all keys
            if (playerKeyCollector.HasAllKeys == true)
            {

                Debug.Log("Victory! Player collected all keys.");
                // Here you could load the victory scene, unlock the door, etc.
                SceneManager.LoadScene("VictoryScene");
            }
            else
            {
                Debug.Log("Door is locked. Collect all keys first.");
            }
        }
    }
}
