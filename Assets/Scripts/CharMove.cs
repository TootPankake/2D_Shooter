using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    private float Xaxis;
    private float speed = 10f; 
    private float Jumps = 12f;
    private bool RightFacing = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Update is called once per frame
    void Update()
    {
        Xaxis = Input.GetAxis("Horizontal");
        
        if(Input.GetKeyDown(KeyCode.W) && TouchingGrass())
        {
            rb.velocity = new Vector2(rb.velocity.x, Jumps);
        }

        
        
        
        
    }

    

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
        
        Xaxis = Input.GetAxis("Horizontal");

       if(Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
            Flip();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
            Flip();
        }
    }
    
    private bool TouchingGrass()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


    private void Flip()
    {
        if(RightFacing && Xaxis < 0f || RightFacing && Xaxis > 0f)
        {
         RightFacing = !RightFacing;
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }
    }
}
