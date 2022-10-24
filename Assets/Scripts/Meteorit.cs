using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorit : MonoBehaviour
{ 

    public Sprite[] modelsMeteorit = new Sprite[4];
    private float _vel = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posicio = transform.position;
        posicio = new Vector2(posicio.x, posicio.y - _vel * Time.deltaTime);

        transform.position = posicio;

        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));

        if (transform.position.y < minPantalla.y)
        {
            //si el projectil surt fora de la pantalla el destruim,
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Meteo")
        {

            Destroy(gameObject);
            GameObject.Find("punts").GetComponent<Punts>().SumaUnPunt();

        }
    }

}