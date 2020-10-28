using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    public healthBarController healthBar;

    private int timesHit;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ennemi")
        {
     
            timesHit++;
            
            
            
        }

        //ex: Si le joueur est frapé TROIS fois par les ennemis, le joueur sera étourdi et il perds 10% de sa health bar
        if (collision.gameObject.tag == "ennemi" && timesHit <= 3)
        {
            timesHit = 0;


            if (healthBar)
            {
                healthBar.OnTakeDamage(10);
            }
        } //ex: si l'ennemi tire sur le joueur, le joueur meurt    
        else if (collision.gameObject.tag == "bullet")
        {
            if (healthBar)
            {
                //healthBar.OnDie(100);
                //Die();

            }
        }


        //si le joueur prendre de médicaments son health bar augmente de 10%
        if (collision.gameObject.tag == "medicament")
        {
            if (healthBar)
            {
                healthBar.OnTakeMedicine(10);
            }
        }
    }

}

