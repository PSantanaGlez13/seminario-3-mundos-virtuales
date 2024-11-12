using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projection_matrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetComponent<Camera>().projectionMatrix);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
