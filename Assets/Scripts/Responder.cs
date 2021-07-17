using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responder : MonoBehaviour
{

    private Material mat;
    public Color toColour;
    
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    public void ChangeColor()
    {
        mat.color = toColour;
    }
    
}
