using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    //public BoxCollider colliderArme;

    public float dommagesArme;

    private float dommagesTotal;

    private bool estUnJoueur;

    private void Start()
    {
        GetComponent<Collider>().enabled = false;
        estUnJoueur = transform.parent.tag == "joueur";
    }

    private void OnCollisionEnter(Collision toucherEnnemi)
    {
        if (estUnJoueur)
        {
            if (toucherEnnemi.gameObject.tag == "ennemi")
            {
                toucherEnnemi.gameObject.GetComponent<healthBarController>().PrendreDommages(dommagesArme);
            }
        }
        else
        {
            if (toucherEnnemi.gameObject.tag == "joueur")
            {
                toucherEnnemi.gameObject.GetComponent<healthBarController>().PrendreDommages(dommagesArme);
            }
        }
    }

    public void MultiplierDommages(float multiplicateur, float tempsDuBoost) {
        dommagesTotal *= multiplicateur;
        Invoke("ArreterMultiplicateurDommages", tempsDuBoost);
    }

    private void ArreterMultiplicateurDommages() {
        dommagesTotal = dommagesArme;
    }

}

