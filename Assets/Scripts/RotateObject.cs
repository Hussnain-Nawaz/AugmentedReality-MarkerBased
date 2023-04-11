using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private GameObject jhonLemon;
    // Update is called once per frame
    void Update()
    {
        jhonLemon= GameObject.FindWithTag("modelMesh");
    }
    public void RotateLeft()
    {
        if (jhonLemon!=null)
        {
            jhonLemon.transform.Rotate(new Vector3(0f, 0f, 20f));  
        }
    }
    public void RotateRight()
    {
        if (jhonLemon != null)
        {
            jhonLemon.transform.Rotate(new Vector3(0f, 0f, -20f));
        }
    }
}
