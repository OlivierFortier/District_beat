using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    public healthBarController healthBar;
    void OnTriggerEnter(Collider collision)
    {
        print("bonjour");

        if (collision.gameObject.tag == "ennemi")
        {
            print("test");

            if (healthBar)
            {
                print("allo");
                healthBar.OnTakeDamage(10);
            }
        }
    }
    
}

