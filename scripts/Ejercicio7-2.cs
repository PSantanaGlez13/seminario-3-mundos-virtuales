using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7-2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Quaternion.Euler(0, 30, 0));
        transform.Translate(2f, 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
