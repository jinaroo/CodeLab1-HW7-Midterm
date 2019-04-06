using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : Enemy
{
    // moves left and right
    private bool dirRight = true;
    public float speed = 2.0f;
    
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight) // go right
            transform.Translate (Vector2.right * speed * Time.deltaTime);
        else // go left
            transform.Translate (-Vector2.right * speed * Time.deltaTime);
        
        if(transform.position.x >= .5f)
        {
            dirRight = false;
        }
        
        if(transform.position.x <= -.5f)
        {
            dirRight = true;
        }
    }
}
