﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
// script de détection de collision entre une arme et un entité
public class toucherEnnemi : MonoBehaviour
{
    // dommages de base de l'arme
    public float dommagesArme;

    // dommages totaux infligés (dommages total + modificateur de dommages)
    private float dommagesTotal;

    // est-ce que c'est un joueur qui inflige avec cette arme ?
    private bool estUnJoueur = false;

    // est-ce que cette arme est un projectile
    private bool estunProjectile = false;
    
    //systeme de particule pour le sang
    public GameObject particuleSang; 
    
    //sons pour les armes
    public AudioClip slashSon; 

    private void Start()
    {
        // configurer les dommages de base
        dommagesTotal = dommagesArme;

        // s'assurer que le collider de l'arme est désactivé au départ
        GetComponent<Collider>().enabled = false;

        // si c'Est un projectile, activer le collider après un certain délai
        if (estunProjectile) Invoke("ActiverCollider", 0.15f);

    
    }

    private void OnCollisionEnter(Collision toucherEnnemi)
    {
        // si c'Est un joueur qui cause les dommages
        if (estUnJoueur)
        {
            // si il touche l'ennemi
            if (toucherEnnemi.gameObject.tag == "ennemi")
            {
                // faire perdre de la vie
                toucherEnnemi.gameObject.GetComponent<ControleurBarreVie>().PrendreDommages(dommagesTotal);

                //faire jouer le son d'un slash d'épée lorsque le joueur frappe un ennemi
                GetComponent<AudioSource>().PlayOneShot(slashSon, 1f);
                //particuleSang.SetActive(true);
                // Instantiate(particuleSang);
               var particules = particuleSang.GetComponent<ParticleSystem>();

               particules.Play();
                

               

            }
        }
        // sinon si c'Est un ennemi qui cause les dommages
        else
        {
            // si il touche un joueur
            if (toucherEnnemi.gameObject.tag == "joueur")
            {
                // faire perdre de la vie
                toucherEnnemi.gameObject.GetComponent<ControleurBarreVie>().PrendreDommages(dommagesTotal);
                   GetComponent<AudioSource>().PlayOneShot(slashSon, 1f);
          
               var particules = particuleSang.GetComponent<ParticleSystem>();

               particules.Play();
       
             
            }
        }

        // si c'est un projectile, détruire après impact
        if (estunProjectile) Destroy(gameObject);

    }

    // méthode pour augmenter les dommages du personnage pendant un certain temps
    public void MultiplierDommages(float multiplicateur, float tempsDuBoost)
    {
        dommagesTotal *= multiplicateur;
        Invoke("ArreterMultiplicateurDommages", tempsDuBoost);
    }

// méthode pour arrêter le boost de dommages
    private void ArreterMultiplicateurDommages()
    {
        dommagesTotal = dommagesArme;
    }

    // méthhode qui permet d'associer un joueur a un projectile
    public void AssocierJoueurAuProjectile(bool vraiFaux)
    {
        estUnJoueur = vraiFaux;
    }

    // méthode qui permet de configurer si l'arme est un projectile
    public void SetProjectile(bool vraiFaux)
    {
        estunProjectile = vraiFaux;
    }

    // méthode permettant d'activer le collider du projectile
    public void ActiverCollider() { GetComponent<Collider>().enabled = true; }

}

