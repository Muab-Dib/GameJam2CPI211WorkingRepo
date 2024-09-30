using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSoundGhost : MonoBehaviour
{
  

    // Array to hold sound clips
    public AudioClip[] soundClips;

    // Reference to the AudioSource component
    private AudioSource audioSource;

    // Minimum and maximum time intervals between sounds
    public float minTimeBetweenSounds = 2f;
    public float maxTimeBetweenSounds = 5f;

    private void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        // Start the coroutine that plays random sounds
        StartCoroutine(PlayRandomSounds());
    }

    private IEnumerator PlayRandomSounds()
    {
        while (true)
        {
            // Pick a random time between min and max time
            float randomTime = Random.Range(minTimeBetweenSounds, maxTimeBetweenSounds);

            // Wait for that amount of time
            yield return new WaitForSeconds(randomTime);

            // Pick a random sound from the array
            if (soundClips.Length > 0)
            {
                AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];

                // Play the selected sound
                audioSource.PlayOneShot(randomClip);
            }
        }
    }
}


