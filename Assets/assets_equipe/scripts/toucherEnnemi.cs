using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    public BoxCollider colliderArme;

    private void OnCollisionEnter(Collision toucherEnnemi)
    {
       if (toucherEnnemi.gameObject.tag == "ennemi")
        {
            toucherEnnemi.gameObject.Enemyhealth--; 
        }   
    }
}

