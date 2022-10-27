using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float Bspeed = 20f;
    public Rigidbody2D rigidb;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidb.velocity = transform.right * Bspeed;
    }

   
}
