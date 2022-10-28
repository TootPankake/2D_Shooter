using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootBehavior : MonoBehaviour
{
  
   public float Pspeed = 15f;
   public Rigidbody2D rigid;
   private bool facingRight = true;
   private float directDetect;
   

    // Update is called once per frame
    private void Update()
    {
        
            directDetect = Input.GetAxis("Horizontal");



            if(facingRight)
            rigid.velocity = transform.right * Pspeed;
            else
            rigid.velocity = transform.right  * Pspeed * -1;

    } 

   
    
}
