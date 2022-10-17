using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarNums : MonoBehaviour
{

    public GameObject _prefabNum;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaNum", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreaNum()
    {
        Vector2 maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        GameObject objectenumero = Instantiate(_prefabNum);

        objectenumero.transform.position =
            new Vector2(Random.Range(minPantalla.x, maxPantalla.x), maxPantalla.y);

    }

}
