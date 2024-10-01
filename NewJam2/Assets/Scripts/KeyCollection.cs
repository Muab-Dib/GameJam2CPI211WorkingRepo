using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Extension;

public class KeyCollection : MonoBehaviour
{
    public TextMeshProUGUI keyCountText;
    public AudioSource keySound;
    public int Keys = 0, totalKeys = 6;
    public bool HasAllKeys = false;
    public AudioSource WoodenDoor;
    public chaserAi chaser;
    private void Start()
    {
        Keys = 0;
        HasAllKeys = false;
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Debug.Log("KeyCollected");
            Keys++;
            if(Keys == totalKeys)
            {
                WoodenDoor.Play();
                HasAllKeys = true;
               // chaser.chasing = true;
            }
            keySound.Play();
            keyCountText.text = Keys + " / " + totalKeys;
            Destroy(other.gameObject);
            Debug.Log("KeyCollected");
        }
    }


}
