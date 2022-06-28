using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeValueChange : MonoBehaviour
{
    
    [SerializeField] Slider volumenSlider;

    // Volumen de la musica modificable
    private float musicVolume = 0.5f;
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("volumenMusica"))
        {
            PlayerPrefs.SetFloat("volumenMusica", 1);
            Cargar();
        }
        else 
        {
            Cargar();
        }

    }

    public void CambiarVolumen() 
    {
        AudioListener.volume = volumenSlider.value;
        Salvar();
    }

    void Update()
    {
        
    }
    
    public void Cargar()
    {
        volumenSlider.value = PlayerPrefs.GetFloat("volumenNusica");
    }
    
    public void Salvar()
    {
        PlayerPrefs.SetFloat("volumenMusica", volumenSlider.value);
    }
}