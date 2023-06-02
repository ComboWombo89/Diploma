using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int pointValue = 1000;
    public bool activateShield;
    public bool addGuns;
    public bool increaseSpeed;
    public float moveSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
    }
    
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        
        if (pos.x < -3)
        {
            Destroy(gameObject);
        }
        
        transform.position = pos;
    }
    
}
