using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toucherEnnemi : MonoBehaviour
{
    public BoxCollider colliderArme;

    public float dommagesArme;

    private bool estUnJoueur;


    private void Start()
    {
        estUnJoueur = GetComponentInParent<GameObject>().tag == "joueur";
    }

    private void OnCollisionEnter(Collision toucherEnnemi)
    {
        if (estUnJoueur)
        {
            if (toucherEnnemi.gameObject.tag == "ennemi")
            {
                //modifie la variable directement
                //toucherEnnemi.gameObject.GetComponent<statsVie>().ennemiVie -= dommagesArme;

                //tu apelle la fonction 
                //toucherEnnemi.gameObject.GetComponent<statsVie>().perdreVie(dommagesArme);
                print("ouch ayoye");
            }
        }
        else
        {
            if (toucherEnnemi.gameObject.tag == "joueur")
            {
                //modifie la variable directement
                //toucherEnnemi.gameObject.GetComponent<statsVie>().ennemiVie -= dommagesArme;

                //tu apelle la fonction 
                //toucherEnnemi.gameObject.GetComponent<statsVie>().perdreVie(dommagesArme);
                print("ouch ayoye");
            }
        }

    }
}

