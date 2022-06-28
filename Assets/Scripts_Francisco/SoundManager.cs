using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioObjeto;

    void Start()
    {
        audioObjeto = GetComponent<AudioSource>();
        audioObjeto.Stop();
    }

    void Update()
    {
        
    }

    public void ActivoSonido() 
    
    {
        audioObjeto.Play();
    } public void DetengoSonido() 
    
    {
        audioObjeto.Stop();
    }
}
