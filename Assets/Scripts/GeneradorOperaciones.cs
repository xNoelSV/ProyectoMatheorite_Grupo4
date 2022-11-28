using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GeneradorOperaciones : MonoBehaviour
{
    private TMPro.TextMeshPro Operacion;
    public int res;
    private String operacionEscrita;
    private int[] resultadoADevolver = new int[13];

    // Start is called before the first frame update
    void Start()
    {
        GenerarOperacion();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = operacionEscrita;
    }

    public void iniciar()
    {
        GenerarOperacion();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = operacionEscrita;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerarOperacion()
    {
        System.Random r = new System.Random();

        String[] operador = new String[4] { "+", "-", "/", "*" };
        String opElegido = operador[r.Next(4)];

        if (opElegido.Equals("+"))
        {
            GameObject.Find("Operacio").GetComponent<TMPro.TextMeshProUGUI>().fontSize = 42;

            int num1 = r.Next(100);
            int num2 = r.Next(100);

            res = num1 + num2;
            operacionEscrita = "x = " + num1.ToString() + "+" + num2.ToString();
        }
        else if (opElegido.Equals("-"))
        {
            GameObject.Find("Operacio").GetComponent<TMPro.TextMeshProUGUI>().fontSize = 42;

            int num1 = r.Next(100);
            int num2 = r.Next(100);

            res = num1 - num2;
            operacionEscrita = "x = " + num1.ToString() + "-" + num2.ToString();
        }
        else if (opElegido.Equals("/"))
        {
            GameObject.Find("Operacio").GetComponent<TMPro.TextMeshProUGUI>().fontSize = 72;

            int num1 = 0;
            int num2 = 0;
            do
            {
                num1 = r.Next(99)+1;
                num2 = r.Next(10)+1;
            } while ((num1 % num2 != 0) || (num1 == 0) || (num2 == 0));
            
            res = num1 / num2;
            operacionEscrita = num1.ToString() + "/" + num2.ToString();
        }
        else if (opElegido.Equals("*"))
        {
            GameObject.Find("Operacio").GetComponent<TMPro.TextMeshProUGUI>().fontSize = 72;

            int num1 = 0;
            int num2 = 0;

            do
            {
                num1 = r.Next(11);
                num2 = r.Next(11);
            } while ((num1 == 0) || (num2 == 0));

            res = num1 * num2;
            operacionEscrita = num1.ToString() + "*" + num2.ToString();
        }

    }

    public int GenerarPosiblesResultats()
    {
        System.Random r = new System.Random();

        resultadoADevolver[0] = res - 5;
        resultadoADevolver[1] = res - 4;
        resultadoADevolver[2] = res - 3;
        resultadoADevolver[3] = res - 2;
        resultadoADevolver[4] = res - 1;
        resultadoADevolver[5] = res;
        resultadoADevolver[6] = res;
        resultadoADevolver[7] = res;
        resultadoADevolver[8] = res + 1;
        resultadoADevolver[9] = res + 2;
        resultadoADevolver[10] = res + 3;
        resultadoADevolver[11] = res + 4;
        resultadoADevolver[12] = res + 5;

        return resultadoADevolver[r.Next(11)];  
    }
}
