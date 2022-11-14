using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMeteoritos : MonoBehaviour
{
    public GameObject Meteorito;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaMeteorito", 2f, 3f);
            // 2f: Tiempo que tarda en llamar por primera vez la función "CrearMeteorito"
            // 3f: Intérvalo de tiempo para llamar de nuevo a la función "CrearMeteorito"
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreaMeteorito()
    {
        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0.7f, 1f));
        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f));

        GameObject objecteMeteo = Instantiate(Meteorito);

        objecteMeteo.transform.position = new Vector2(Random.Range(minPantalla.x, maxPantalla.x), maxPantalla.y);

    }
}
