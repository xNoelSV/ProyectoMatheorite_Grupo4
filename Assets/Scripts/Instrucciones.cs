using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instrucciones : MonoBehaviour
{
     string frase ="¡No choques con ningún meteorito! Sinó, la nave va a perder parte del escudo. \n \n Destruye los meteoritos con el resultado de la operación correcta. \n \n Si se destruye un meteorito con el resultado incorrecto, la se restará 5 puntos y una parte del escudo \n \n Usa la “W”, “A”, “S” y “D” para moverte por la pantalla. \n \n Usa la tecla “Space” (Espacio) para poder disparar. \n \nEstate atento para no chocar y acumula los máximos puntos posibles. ";
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
