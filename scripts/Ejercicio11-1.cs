using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11_1 : MonoBehaviour
{
    public Matrix4x4 viewMatrix;
    // Start is called before the first frame update
    void Start()
    {
        if (Camera.main != null)
        {
            viewMatrix = Camera.main.worldToCameraMatrix;
            Debug.Log(viewMatrix);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
