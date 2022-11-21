using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vides : MonoBehaviour
{
    private TMPro.TextMeshPro Vidas;
    private int vidasTotales = 3;

    public void RestarVida()
    {
        vidasTotales -= 1;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = vidasTotales.ToString();
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
