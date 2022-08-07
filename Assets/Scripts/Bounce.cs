using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] AudioClip bounceSfx;
    [SerializeField] float bounceVolume = 0.1f;

    private void OnCollisionEnter(Collision other) 
    {
        AudioSource.PlayClipAtPoint(bounceSfx, transform.position, bounceVolume);
    }
}
