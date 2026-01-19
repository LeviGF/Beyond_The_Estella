using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo_Move_V3 : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        Vector2 offsert = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offsert; 
    }
}
