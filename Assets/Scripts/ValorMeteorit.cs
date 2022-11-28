using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValorMeteorit : MonoBehaviour
{

    public int numeroMeteorit;
    private TMPro.TextMeshPro Texto;

    // Start is called before the first frame update
    void Start()
    {
        numeroMeteorit = GameObject.Find("Operacio").GetComponent<GeneradorOperaciones>().GenerarPosiblesResultats();
        gameObject.GetComponent<TMPro.TextMeshPro>().text = numeroMeteorit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
