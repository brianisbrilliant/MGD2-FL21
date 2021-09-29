using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum soundType {Hurt, HitBadButton, HitGoodButton, Miss};

public class PlayAudio : MonoBehaviour
{   
    // an array of audio clips
    public AudioClip[] clips;

    private AudioSource aud;

    void Start() {
        aud = GetComponent<AudioSource>();

        PlayClip(soundType.Hurt);
    }


    public void PlayClip(soundType type) {
        aud.PlayOneShot(clips[(int)type]);
    }
}
