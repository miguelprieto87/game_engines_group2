using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudioManager : MonoBehaviour
{

    public static ButtonAudioManager instance;
    public AudioClip SFX;
    public AudioSource audioSound;

    public AudioClip SFX2;
    public AudioSource audioSound2;

    public AudioClip SFX3;
    public AudioSource audioSound3;

    private void Awake()
    {
        // if the game manager instance does not exists
        if (ButtonAudioManager.instance == null)
        {
            // This is to make sure that the singleton is established
            instance = this;
        }
        else
        { // Otherwise I am a duplicate and I would like to remove myself
            Destroy(gameObject);
        }

        // dont want this to be destroyed
        DontDestroyOnLoad(gameObject);
    }

    public void PlayAudio1()
    {
        audioSound.clip = SFX;
        audioSound.Play();
    }

    public void PlayAudio2()
    {
        audioSound2.clip = SFX2;
        audioSound2.Play();
    }

    public void PlayAudio3()
    {
        audioSound3.clip = SFX3;
        audioSound3.Play();
    }
}
