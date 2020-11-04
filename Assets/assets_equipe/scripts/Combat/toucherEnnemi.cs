using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    //public BoxCollider colliderArme;

    public float dommagesArme;

    private float dommagesTotal;

    private bool estUnJoueur;

    private bool estunProjectile;

    private void Start()
    {
        GetComponent<Collider>().enabled = false;
    }

    private void OnCollisionEnter(Collision toucherEnnemi)
    {
        if (estUnJoueur)
        {
            if (toucherEnnemi.gameObject.tag == "ennemi")
            {
                toucherEnnemi.gameObject.GetComponent<healthBarController>().PrendreDommages(dommagesTotal);
            }
        }
        else
        {
            if (toucherEnnemi.gameObject.tag == "joueur")
            {
                toucherEnnemi.gameObject.GetComponent<healthBarController>().PrendreDommages(dommagesTotal);
            }
        }

        Destroy(gameObject);

    }

    public void MultiplierDommages(float multiplicateur, float tempsDuBoost) {
        dommagesTotal *= multiplicateur;
        Invoke("ArreterMultiplicateurDommages", tempsDuBoost);
    }

    private void ArreterMultiplicateurDommages() {
        dommagesTotal = dommagesArme;
    }

    public void AssocierJoueurAuProjectile(bool estUnJoueur) {
        this.estUnJoueur = estUnJoueur;
    }

    public void SetProjectile(bool estunProjectile) {
        this.estunProjectile = estunProjectile;
    }

}

