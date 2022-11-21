using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vides : MonoBehaviour
{
    private TMPro.TextMeshPro Vidas;
    private int vidasTotales = 3;

    public bool RestarVida()
    {
        if (vidasTotales -1 == 0)
        {
            SceneManager.LoadScene("MainMenu");
            return true;
        } 
        else
        {
            vidasTotales -= 1;
            gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = vidasTotales.ToString();
            return false;
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
