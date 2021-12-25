using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.localScale += new Vector3(0.01f, 0, 0);
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.Translate(new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime));
    }
}
