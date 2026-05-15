using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public void PlaySound()
    {
        audioSource.Play();
        audioSource2.Play();
    }

    public void StopSound()
    {
        audioSource.Stop();
    }
}

