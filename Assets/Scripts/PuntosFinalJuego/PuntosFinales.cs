using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosFinales : MonoBehaviour
{

    private TMPro.TextMeshPro textoFinal;
    private string puntosFinal = "";

    // Start is called before the first frame update
    void Start()
    {
        textoFinal = gameObject.GetComponent<TMPro.TextMeshPro>();
    }
    public void InsertarPuntos()
    {
        puntosFinal = GameObject.Find("PuntosFinal").GetComponent<PuntosFinal>().puntosFinal;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Puntos totales: " + puntosFinal;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
