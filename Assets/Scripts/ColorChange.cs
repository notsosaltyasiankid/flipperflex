using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    [SerializeField] MeshRenderer meshRenderer;

    public void ChangeColor(){
        meshRenderer.material.color = Color.green;
    }
    
}
