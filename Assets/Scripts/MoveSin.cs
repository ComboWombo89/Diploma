using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    private float sinCenterY; 
    float amplitude = 2;
    public float frequensy = 0.5f;
    public bool inverted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x * frequensy) * amplitude;
        if (inverted)
        {
            sin *= -1;
        }
        pos.y = sinCenterY + sin;
        
        transform.position = pos;
    }
}
