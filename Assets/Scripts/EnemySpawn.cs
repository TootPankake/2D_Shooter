using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    float timer = 0f;
    public GameObject EnemyPrefab;
    private Vector2 spawn;
    private bool rand = true;
    
    

   
    // Update is called once per frame
    void Update()
    {
       
       ++timer;
        if(timer >=450)
        {
           
         if(rand) 
         {
          Instantiate(EnemyPrefab, transform.position , transform.rotation);
          timer = 0;
          Debug.Log("Hi");
          rand = false;
         }
         else
         {
          Instantiate(EnemyPrefab, new Vector3(10, 2, 0) , transform.rotation);
          timer = 0;
          Debug.Log("Hi");
          rand = true;
         }
                     
        }
    }
}
