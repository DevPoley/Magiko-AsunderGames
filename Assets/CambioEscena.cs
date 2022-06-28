using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscena : MonoBehaviour
{
    public Animator animacion;
    public MedallonAnima medallonAparece;
    [Header("Partilulas Medallon")]
    public ParticleSystem particulaMedallon;

    void Start()
    {
        animacion = GetComponent<Animator>();
        medallonAparece = GetComponent<MedallonAnima>();
        particulaMedallon.Stop();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("CAMBIO DE ESCENA RICAMENTE");

            animacion.SetInteger("Gemas", 0);
            Invoke("Gemas(1)",1f);

            Invoke("LlamadaParticulaExterna", 10);
        }
    }

    private void Gemas(int g)
    {
        animacion.SetInteger("Gemas", g);
    }

    void LlamadaParticulaExterna()
    {
        particulaMedallon.Play();
    }
}






