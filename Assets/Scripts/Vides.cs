using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vides : MonoBehaviour
{
    private TMPro.TextMeshPro Vidas;
    private int vidasTotales = 3;
    private int final = 0;
    public int contadorAciertos = 0;

    public bool RestarVida()
    {
        if (vidasTotales -1 == 0)
        {
            final = GameObject.Find("Puntos").GetComponent<Punts>().puntosTotales -5;
            GameObject.Find("PuntosFinal").GetComponent<PuntosFinal>().puntosFinal = final.ToString();
            SceneManager.LoadScene("GameOver");
            return true;
        } 
        else
        {
            vidasTotales -= 1;
            gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = vidasTotales.ToString();
            return false;
        }
        
    }

    public void ComprobarSumarVida()
    {
        contadorAciertos++;

        if (contadorAciertos == 3)
        {
            vidasTotales += 1;
            gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = vidasTotales.ToString();
            contadorAciertos = 0;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        Vidas = gameObject.GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
