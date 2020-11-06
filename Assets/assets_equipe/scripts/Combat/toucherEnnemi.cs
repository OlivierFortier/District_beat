using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    //public BoxCollider colliderArme;

    public float dommagesArme;

    private float dommagesTotal;

    private bool estUnJoueur = false;

    private bool estunProjectile = false;

    public int lay1;

    public int lay2;

    private void Start()
    {
        
        dommagesTotal = dommagesArme;

        GetComponent<Collider>().enabled = false;



        if (estunProjectile) Invoke("ActiverCollider", 0.15f);
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

        if (estunProjectile) Destroy(gameObject);

    }

    public void MultiplierDommages(float multiplicateur, float tempsDuBoost)
    {
        dommagesTotal *= multiplicateur;
        Invoke("ArreterMultiplicateurDommages", tempsDuBoost);
    }

    private void ArreterMultiplicateurDommages()
    {
        dommagesTotal = dommagesArme;
    }

    public void AssocierJoueurAuProjectile(bool vraiFaux)
    {
        estUnJoueur = vraiFaux;
    }

    public void SetProjectile(bool vraiFaux)
    {
        estunProjectile = vraiFaux;
    }

    public void ActiverCollider() { GetComponent<Collider>().enabled = true; }

}

