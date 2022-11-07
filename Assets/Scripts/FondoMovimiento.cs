using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{

    [SerializeField] private Vector2 velocidadMovimiento;

    private Vector2 offset;

    private Material material;


    private void Awake(){
        material = GetComponent<SpriteRenderer>().material;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
