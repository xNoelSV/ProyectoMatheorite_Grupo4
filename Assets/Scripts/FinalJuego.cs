using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJuego : MonoBehaviour
{

    private TMPro.TextMeshPro PuntosTotales;
    private String puntosFinales;

    // Start is called before the first frame update
    void Start()
    {
        PuntosTotales = gameObject.GetComponent<TMPro.TextMeshPro>();
    }

    public void InsertarPuntos(int i)
    {
        puntosFinales = "Puntos totales: " + i;
            //GameObject.Find("Puntos").GetComponent<Punts>().puntosTotales.ToString();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = puntosFinales;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
