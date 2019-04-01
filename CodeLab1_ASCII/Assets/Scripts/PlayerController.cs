using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float maxSpeed;
    public float jumpForce;
    
    // ground check
    private bool grounded = false;
    public Transform groundCheck;
    public float groundCheckHeight = 1f;
    public LayerMask whatIsGround;
    
    // controls
    public KeyCode jump;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.725f, groundCheckHeight), 0, whatIsGround);

        // movement
        float moveDirection = Input.GetAxis("Horizontal"); // checks to see if player is going left or right
        rb.velocity = new Vector2(moveDirection * maxSpeed, rb.velocity.y);

        if (grounded && Input.GetKeyDown(jump))
            rb.AddForce(new Vector2(0, jumpForce));
            
    }
}
