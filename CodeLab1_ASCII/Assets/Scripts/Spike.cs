using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Enemy
{
    // moves up and down on a timer
    public float activeSpikeTime;
    private float nextSpikeTime;

    public bool isSpikeUp;
    
    private Vector3 upPos;
    public Vector3 downPos; // offset
    public float spikeMoveSpeed;

    private PolygonCollider2D spikeCollider;
    
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start(); // calls enemy script start function
        
        nextSpikeTime = Time.timeSinceLevelLoad + activeSpikeTime;
        upPos = transform.localPosition;
        downPos = transform.localPosition + downPos;
        if(!isSpikeUp) // checks if spike should start in down pos
            transform.localPosition = downPos; // moves spike start position down
        spikeCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextSpikeTime)
        {
            // update spike state
            isSpikeUp = !isSpikeUp;
            nextSpikeTime = Time.timeSinceLevelLoad + activeSpikeTime;
        }
        
        if (isSpikeUp) // move to upPos
        {
            spikeCollider.enabled = true;
            transform.localPosition = Vector3.Lerp(transform.localPosition, upPos, spikeMoveSpeed * Time.deltaTime);
        }
        else // move to downPos
        {
            spikeCollider.enabled = false;
            transform.localPosition = Vector3.Lerp(transform.localPosition, downPos, spikeMoveSpeed * Time.deltaTime);
        }
    }
}
