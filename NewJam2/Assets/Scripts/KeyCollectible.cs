using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public AudioSource keySound;
    private int keys = 0;

    public TextMeshProUGUI keysCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            keys++;
            // coinSound.Play();
            keysCollected.text = "Keys Collected: " + keys.ToString();
            Destroy(other.gameObject);
            Debug.Log("KeyCollected");
        }
    }



}