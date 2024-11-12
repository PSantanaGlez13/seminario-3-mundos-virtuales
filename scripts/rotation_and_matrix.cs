using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_and_matrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Before rotation: " + transform.localToWorldMatrix);
        transform.Rotate(0f, 90f, 90f);
        Debug.Log("After rotation: " + transform.localToWorldMatrix); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
