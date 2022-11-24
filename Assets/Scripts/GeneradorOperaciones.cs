using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GeneradorOperaciones : MonoBehaviour
{

    private TMPro.TextMeshPro Operacion;
    private int res;
    private String operacionEscrita;

    // Start is called before the first frame update
    void Start()
    {
        GenerarOperacion();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = operacionEscrita;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarOperacion()
    {
        System.Random r = new System.Random();

        String[] operador = new String[4] { "+", "-", "/", "*" };
        String opElegido = operador[r.Next(4)];

        if (opElegido.Equals("+"))
        {
            int num1 = r.Next(100);
            int num2 = r.Next(100);

            res = num1 + num2;
            operacionEscrita = "x = " + num1.ToString() + " + " + num2.ToString();
        }
        else if (opElegido.Equals("-"))
        {
            int num1 = r.Next(100);
            int num2 = r.Next(100);

            res = num1 - num2;
            operacionEscrita = "x = " + num1.ToString() + " + " + num2.ToString();
        }
        else if (opElegido.Equals("/"))
        {
            int num1 = 0;
            int num2 = 0;
            do
            {
                num1 = r.Next(100);
                num2 = r.Next(100);
            } while (num1 % num2 != 0);
            
            res = num1 / num2;
            operacionEscrita = num1.ToString() + " + " + num2.ToString();
        }
        else if (opElegido.Equals("*"))
        {
            int num1 = r.Next(10);
            int num2 = r.Next(10);

            res = num1 * num2;
        }

    }

    private String resultadosOperaciones()
    {
        int numGenerat = 0;
        String res = "";



        return res;
    }
}
