using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class view_model_matrices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Model: " + transform.localToWorldMatrix);
        Debug.Log("View: " + GetComponent<Camera>().worldToCameraMatrix);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
