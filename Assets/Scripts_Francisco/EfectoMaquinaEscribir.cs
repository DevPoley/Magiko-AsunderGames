using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EfectoMaquinaEscribir : MonoBehaviour

{
    public float velocidadRetardo = 0.01f;  //velocidad escritura
    public string textoCompleto; //mostraria texto al completo
    public string textoActual = "";

    [SerializeField] GameObject objetoSonidoLetras;
    [SerializeField] AudioSource sonidoLetras;
    string nombreTag = "SFX";
    void Start()
    {
        StartCoroutine(MostrarDialogos());
        objetoSonidoLetras = GameObject.FindGameObjectWithTag(nombreTag);
        sonidoLetras = objetoSonidoLetras.GetComponent<AudioSource>();
            }

    IEnumerator MostrarDialogos() 
    {
        for (int i = 0; i < textoCompleto.Length; i++)
        {
            textoActual = textoCompleto.Substring(0, i);
            this.GetComponent<Text>().text = textoActual;
            yield return new WaitForSeconds(velocidadRetardo);
            sonidoLetras.Play();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
       }
    }

}
