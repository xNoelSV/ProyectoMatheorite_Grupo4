using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoMovimiento : MonoBehaviour
{
      string frase = "La Nathorite Interpret se dio cuenta de que un meteorito iba dirección a la Tierra, lanzaron misiles para desviarlo,  pero con eso lo único que lograron fue dividir el meteorito \n \n Por culpa del misil láser el meteorito cogió radiación y pasaron de ser meteoritos normales y corrientes a Matheorite, unos meteoritos con voluntad propia con números de resultados matemáticos dispuestos a destruir las naves necesarias para sobrevivir. \n \nSin mucha demora tomaron una decisión, salir al espacio exterior y exterminar cada uno de los Matheorites";
    // Start is called before the first frame update
    public Text texto;
    void Start()
    {
         StartCoroutine(Reloj());
    }

     IEnumerator Reloj()
     {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.01f);
        }
    }

    // Update is called once per frame
   
}
