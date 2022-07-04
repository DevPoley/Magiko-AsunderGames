using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioObjeto;
    public AudioSource audioObjeto2;
    public float fadeTime = 1;

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

    public void FadeMusica()

    {
        StartCoroutine(FadeAudioSource.StartFade(audioObjeto, 3, 0));
        StartCoroutine(FadeAudioSource.StartFade(audioObjeto2, 1, 0.05f));

    }
    /*
   IEnumerator _FadeMusica()
   {
       float t = fadeTime;
       while (t > 0)
       {
           yield return null;
           t -= Time.deltaTime;
           audioObjeto.volume = t / fadeTime;
       }
       yield break;
   }
   */
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



}



