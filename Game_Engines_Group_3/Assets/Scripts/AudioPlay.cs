using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    public void PlaySound(AudioSource audioSource) 
    {
        AudioManager.instance.PlaySound(audioSource);        
    }

}
