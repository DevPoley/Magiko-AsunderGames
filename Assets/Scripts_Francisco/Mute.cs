using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void MutearSonidos() 
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void MuteoToggle(bool muteado) 
    {
        if (muteado)
        {
            AudioListener.volume = 0;
        }
        else {
            AudioListener.volume = 1;
        }
    }
}
