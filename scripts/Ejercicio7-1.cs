using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7-1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        transform.Translate(2f, 2f, 2f);
        transform.rotation *= Quaternion.Euler(0, 30, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
