using UnityEngine;
using TMPro; // Namespace for TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    private int keysCollected = 0;
    public int totalKeys = 6; // Total number of keys in the game

    public TextMeshProUGUI keyCountText; // Assign this in the Inspector (drag the TextMeshPro UI here)

    void Awake()
    {
        // Set up the singleton instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Make sure the GameManager persists across scenes
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        UpdateKeyCountUI();
    }

    // Method to call when a key is collected
    public void CollectKey()
    {
        keysCollected++;
        UpdateKeyCountUI();
    }

    // Update the key count on the HUD
    private void UpdateKeyCountUI()
    {
        keyCountText.text = "Keys: " + keysCollected + " / " + totalKeys;
    }
}