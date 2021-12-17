using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    public void PlaySoundInventory() 
    {
        ButtonAudioManager.instance.PlayAudio1();        
    }

    public void PlaySoundMenu()
    {
        ButtonAudioManager.instance.PlayAudio2();
    }

}
