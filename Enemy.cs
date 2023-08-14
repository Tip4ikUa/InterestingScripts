using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;
    public int Damage;
    // Start is called before the first frame update
   
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 0)
        {
            Destroy(gameObject);
        }
        
       
    }
}
