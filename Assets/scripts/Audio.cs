using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio instance;

    public AudioSource audioSource;

   

    private void Awake()
    {
        instance = this;
    }

   
    public AudioClip[] clips;

    public void PlayClip(int index)
    {
        if (index >= 0 && index < clips.Length)
        {
            audioSource.PlayOneShot(clips[index]);
        }
    }

    
}
