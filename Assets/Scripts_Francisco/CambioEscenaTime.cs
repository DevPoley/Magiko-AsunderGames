using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioEscenaTime : MonoBehaviour
{
     float tiempoInicio = 0f;
     float tiempoFinal = 15f;

    [SerializeField] AudioSource musicadeFondo;
    //[SerializeField] GameObject objetoMusicaFondo;
    //string nombreTag = "MusicaFondo";



    public void Start()
    {

        StartCoroutine(FadeAudio.FadeOUT(musicadeFondo, 15, 0));
        //objetoMusicaFondo = GameObject.FindGameObjectWithTag(nombreTag);
        //musicadeFondo = objetoMusicaFondo.GetComponent<AudioSource>();
    }

    void Update()
    {
        tiempoInicio += Time.deltaTime;
        if (tiempoInicio >= tiempoFinal)
        {

            SceneManager.LoadScene(1);
        }
    }
}

public class FadeAudio : MonoBehaviour
{
    public static IEnumerator FadeOUT(AudioSource audioSource, float duration, float targetVolume)
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
