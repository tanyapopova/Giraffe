using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute_audio : MonoBehaviour
{
    public void MuteAudio(bool muted)
    {
        if(muted)
        {
        AudioListener.volume = 0;
        }
        else
        {
        AudioListener.volume = 1;
        }
    }
}
