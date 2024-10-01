using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true; // Show the cursor
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor so it can move freely
    }
    public void Play()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        // alternate way to call a particular screen
        SceneManager.LoadScene("Levels");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
