using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posBullet1 = transform.position;
        posBullet1 = new Vector2(posBullet1.x, posBullet1.y + _vel * Time.deltaTime);

        transform.position = posBullet1;

        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if(transform.position.y > maxPantalla.y){
            //si el projectil surt fora de la pantalla el destruim,
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Meteorito")
        {
            Destroy(gameObject);
        }
    }

}
