using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_UI : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelAjustes;
    public GameObject panelCreditos;
    public GameObject botonPause;
    public GameObject botonNoPause;

    [SerializeField] GameObject objetoSonidoLetras;
    public AudioSource audioObjeto;
    public AudioSource audioObjeto2;
    string nombreTag = "SFX";
    // public SoundManager paraSonidos; //revisar

    void Start()
    {

        panelInicio.SetActive(true);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
        botonPause.SetActive(true);
        botonNoPause.SetActive(false);
        //     paraSonidos = GetComponent<SoundManager>();  //revisar
        objetoSonidoLetras = GameObject.FindGameObjectWithTag(nombreTag);
        audioObjeto = objetoSonidoLetras.GetComponent<AudioSource>();
    }
       
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//pausamos el juego con Esc
        {
            MenuInicial();
            //           paraSonidos.DetengoSonido();
            StartCoroutine(FadeAudioSource.StartFade(audioObjeto, 5, 1));
        }
    }

    public class FadeAudioSource : MonoBehaviour
    {
        public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
        {
            float currentTime = 0;
            float start = audioSource.volume;
            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
                yield return null;
            }
            yield break;
        }
    }
    public void InicioJuego() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
    }
    public void PanelAjustes() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(true);
        panelCreditos.SetActive(false);
    }
    public void PanelCreditos() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(true);
    }
    public void MenuInicial()
    {
        panelInicio.SetActive(true);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
        Time.timeScale = 0;
    }
    public void SalirDelJuego()//METODO DE CIERRE JUEGO
    { 
        Application.Quit();
        Debug.Log("Juego Cerrado");
    }
    public void PausarJuego()//METODO PAUSAR EL JUEGO //
    {
        botonPause.SetActive(false);
        botonNoPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayPauseJuego()//METODO PAUSAR EL JUEGO //
    {
        botonPause.SetActive(true);
        botonNoPause.SetActive(false);
        Time.timeScale = 1;
    }
}
