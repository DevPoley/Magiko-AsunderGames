using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidosBotones : MonoBehaviour
{
    public AudioSource audiBotones;
    public Button boton;
    public AudioClip clipSonido;
    public AudioListener audioListenerCamara;
    void Start()
    {
        audiBotones = GetComponent<AudioSource>();
        gameObject.AddComponent<AudioSource>();
        boton.onClick.AddListener(SonidoBoton);
        audioListenerCamara = GetComponent<AudioListener>();


}

void Update()
    {
        
    }
    public void SonidoBoton() 
    {
        audiBotones.Play();
        Debug.Log("SUENA SONIDO");
    }

}
