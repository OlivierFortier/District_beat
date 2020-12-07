using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
// script de gestion des items ramassables dans le jeu (médecine, speed, neon, morphine)
public class ItemLoot : MonoBehaviour
{

    // type des items de loot
    public enum TypeItem { PackVie, Speed, Morphine, Neon }
    public TypeItem typeItem;

    // temps de durée du boost de l'item
    public float tempsDuBoost = 5f;

    // valeur qui augmente une certaine statistique
    public int valeurDuBoost = 15;

    // Jouer un son lorsque le joueur prendre des items 
    public AudioClip ramassageSon; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("joueur"))
        {
            // gestion différente selon le type sélectionné de l'item dans l'inspecteur unity
            switch (typeItem)
            {
                case TypeItem.PackVie:
                    PrendrePackVie(collision.gameObject);
                    break;

                case TypeItem.Speed:
                    PrendreSpeed(collision.gameObject);
                    break;

                case TypeItem.Morphine:
                    PrendreMorphine(collision.gameObject);
                    break;

                case TypeItem.Neon:
                    PrendreNeon(collision.gameObject);
                    break;

                default:
                    PrendrePackVie(collision.gameObject);
                    break;
            }

            //détruire l'objet après avoir interragi avec
            Destroy(gameObject);

        }
    }

    private void PrendrePackVie(GameObject joueur)
    {
        var scriptVie = joueur.GetComponent<healthBarController>();
        scriptVie.PrendreMedecine(valeurDuBoost);
        GetComponent<AudioSource>().PlayOneShot(ramassageSon, 0.5f);
    }

    private void PrendreSpeed(GameObject joueur)
    {
        var scriptVitesse = joueur.GetComponent<ControlleurJoueur>();
        scriptVitesse.AugmenterVitesseDeBase(valeurDuBoost, tempsDuBoost);
        GetComponent<AudioSource>().PlayOneShot(ramassageSon, 0.5f);
    }

    private void PrendreMorphine(GameObject joueur)
    {
        var scriptVie = joueur.GetComponent<healthBarController>();
        scriptVie.AugmenterResistance(valeurDuBoost, tempsDuBoost);
        GetComponent<AudioSource>().PlayOneShot(ramassageSon, 0.5f);
    }

    private void PrendreNeon(GameObject joueur)
    {
        var scriptArme = joueur.GetComponent<CombatMelee>().attaqueArme.GetComponent<toucherEnnemi>();
        scriptArme.MultiplierDommages(valeurDuBoost, tempsDuBoost);
        GetComponent<AudioSource>().PlayOneShot(ramassageSon, 0.5f);
    }




}
