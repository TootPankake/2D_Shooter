using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{


    public GameObject Prefab;
    public Transform character;
    public float moveSpeed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 move;
    int hit = 0;
    int count = 0;
    

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = character.position - transform.position;
        direction.Normalize();
        move = direction;
    }
    
    private void FixedUpdate()
    {
        moveChar(move);
    }

    void moveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private bool TouchingGrass()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
   {
    Destroy(collision.gameObject);
    ++hit;
    if(hit >= 2)
    {
        Destroy(this.gameObject);
        ++count;
        
    }
   }
}
