using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : Enemy
{
    // moves left and right
    private bool dirRight = true;

    public float speed = .5f;
    public float pathWidth = 2.0f;

    public Vector3 rightEnd;
    public Vector3 leftEnd;
    
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        rightEnd = transform.localPosition + Vector3.right * (pathWidth / 2);
        leftEnd = transform.localPosition + Vector3.left * (pathWidth / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, rightEnd, speed * Time.deltaTime);
            if (transform.localPosition == rightEnd)
            {
                dirRight = false;
            }
        }
        else
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, leftEnd, speed * Time.deltaTime);
            if (transform.localPosition == leftEnd)
            {
                dirRight = true;
            }
        }
               
    }
}
