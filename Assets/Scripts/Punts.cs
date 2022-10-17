using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punts : MonoBehaviour
{

    private TMPro.TextMeshPro _punts;
    private int _puntsEnter = 0;

    public void SumaUnPunt()
    {
        _puntsEnter++;
        // _punts.text = _puntsEnter.ToString();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = _puntsEnter.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        _punts = gameObject.GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
