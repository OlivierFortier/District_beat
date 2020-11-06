using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    //public BoxCollider colliderArme;

    public float dommagesArme;

    private float dommagesTotal;

    private bool estUnJoueur;

    private bool estunProjectile = false;

    public int lay1;

    public int lay2;

    private void Start()
    {
        GetComponent<Collider>().enabled = false;
         if (estunProjectile) ActiverCollider();

        if (estUnJoueur)
        {//Physics.IgnoreCollision(myParent.GetComponent<Collider>(), GetComponent<Collider>());
            Physics.IgnoreLayerCollision(9, 12, true);

        }
        else
        {
            Physics.IgnoreLayerCollision(11, 12, true);
        }
       
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

    public void AssocierJoueurAuProjectile(bool estUnJoueur)
    {
        this.estUnJoueur = estUnJoueur;
    }

    public void SetProjectile(bool estunProjectile)
    {
        this.estunProjectile = estunProjectile;
    }

    public void ActiverCollider() { GetComponent<Collider>().enabled = true; }

}

