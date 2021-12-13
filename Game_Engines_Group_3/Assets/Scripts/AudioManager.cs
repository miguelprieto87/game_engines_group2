using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    //public AudioClip sfx;
    //public AudioSource audioS;

    private void Start()
    {
        //audioS.clip = sfx;
    }

    public void Awake()
    {
        if (AudioManager.instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);//Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySound(AudioSource audioS)
    {
        audioS.Play();
    }
}
