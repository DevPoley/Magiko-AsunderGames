using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FueraLimites : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        FisicasCaracterControler scriptPlayer = other.GetComponent<FisicasCaracterControler>();
        if (scriptPlayer != null)
        {
            Debug.Log("Entro al collider fuera de limites y murio");
        scriptPlayer.Morir();//daba error al intentar coger el script
        }

    }
}
