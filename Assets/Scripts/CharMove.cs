using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    private float Xaxis;
    private float speed = 10f; 
    private float Jumps = 12f;
    private bool RightFacing = true;
    public Transform LaunchOffset;
    public GameObject ShootPrefab;
   
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ShootPrefab,LaunchOffset.position, transform.rotation);
        }
        
        rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
        
        if(Input.GetKeyDown(KeyCode.A) )
        {
            rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
            RightFacing = true;
            Flip();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(Xaxis * speed, rb.velocity.y);
            RightFacing = false;
            Flip();
        }
    }

    private bool TouchingGrass()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void Flip()
    {
        if(RightFacing)
        {
            gameObject.transform.localRotation = Quaternion.Euler(0,180,0);
        }
        else
        {
            gameObject.transform.localRotation = Quaternion.Euler(0,0,0);
        }
    }
}
