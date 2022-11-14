using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punts : MonoBehaviour
{

    private TMPro.TextMeshPro Puntos;
    private int puntosTotales = 0;

    public void SumarPuntos()
    {
        puntosTotales += 10;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = puntosTotales.ToString();
    }

    public void RestarPuntos()
    {
        puntosTotales -= 5;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = puntosTotales.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        Puntos = gameObject.GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
