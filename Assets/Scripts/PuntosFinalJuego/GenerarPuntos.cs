using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("textoFinal").GetComponent<PuntosFinales>().InsertarPuntos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
