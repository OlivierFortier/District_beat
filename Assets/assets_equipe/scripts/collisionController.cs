using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    public healthBarController healthBar;
    void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.tag == "ennemi")
        {
           

            if (healthBar)
            {
                
                healthBar.OnTakeDamage(10);
            }
        }
    }
    
}

