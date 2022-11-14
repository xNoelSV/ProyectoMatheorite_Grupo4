using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float _vel = 8;

    public GameObject _prefabProjectil;
    public GameObject _posicioCanon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject projectil = Instantiate(_prefabProjectil);
            projectil.transform.position = _posicioCanon.transform.position;
        }
        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(x: 0, y: 0));
        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(x: 1, y: 1));

        minPantalla.x += 0.8f;
        maxPantalla.x -= 5.734f; //maxPantalla.x -= 0.8f + 4.91f;

        minPantalla.y += 0.6f;
        maxPantalla.y -= 0.6f;

        float direccioX = Input.GetAxisRaw("Horizontal");
        float direccioy = Input.GetAxisRaw("Vertical");

        //Debug.Log(message: "direccioX: " + direccioX + " - direccioY: " + direccioy);

        Vector2 direccioIndicada = new Vector2(direccioX, direccioy).normalized;

        //trobem pos actual nau:
        Vector2 posNova = transform.position;
        posNova += direccioIndicada * _vel * Time.deltaTime;

        posNova.x = Mathf.Clamp(posNova.x, minPantalla.x, maxPantalla.x);
        posNova.y = Mathf.Clamp(posNova.y, minPantalla.y, maxPantalla.y);

        transform.position = posNova;

        // Debug.Log(message: "posNova: " + posNova);
    }

}
