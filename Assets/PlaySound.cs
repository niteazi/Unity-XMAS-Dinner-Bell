using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource source;
    Collider2D soundTrigger;
    public AudioClip[] sounds;

   
    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
    
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.Play();
    }
}
