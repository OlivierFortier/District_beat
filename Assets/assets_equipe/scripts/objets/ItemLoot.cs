using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoot : MonoBehaviour
{

    public enum TypeItem { PackVie, Speed, Morphine, Neon }
    public TypeItem typeItem;

    public float tempsDuBoost = 5f;

    public int valeurDuBoost = 15f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("joueur"))
        {
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
    }

    private void PrendreSpeed(GameObject joueur)
    {
        var scriptVitesse = joueur.GetComponent<mouvementJoueur>();
        scriptVitesse.AugmenterVitesseDeBase(valeurDuBoost, tempsDuBoost);
    }

    private void PrendreMorphine(GameObject joueur)
    {
        var scriptVie = joueur.GetComponent<healthBarController>();
        scriptVie.AugmenterResistance(valeurDuBoost, tempsDuBoost);
    }

    private void PrendreNeon(GameObject joueur)
    {
        var scriptArme = joueur.GetComponent<CombatMelee>().attaqueArme.GetComponent<toucherEnnemi>();
        scriptArme.MultiplierDommages(valeurDuBoost, tempsDuBoost);
    }




}
