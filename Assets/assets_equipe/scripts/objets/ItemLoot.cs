using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoot : MonoBehaviour
{

    public enum TypeItem { PackVie, Speed, Morphine, Neon }
    public TypeItem typeItem;

    private void OnCollisionEnter(Collision entitee)
    {
        if (entitee.gameObject.CompareTag("joueur"))
        {
            switch (typeItem)
            {
                case TypeItem.PackVie:
                    PrendrePackVie(entitee.gameObject);
                    break;

                case TypeItem.Speed:
                    PrendreSpeed(entitee.gameObject);
                    break;

                case TypeItem.Morphine:
                    PrendreMorphine(entitee.gameObject);
                    break;

                case TypeItem.Neon:
                    PrendreNeon(entitee.gameObject);
                    break;

                default:
                    PrendrePackVie(entitee.gameObject);
                    break;
            }

        }
    }

    private void PrendrePackVie(GameObject joueur)
    {
        var scriptVie = joueur.GetComponent<healthBarController>();
        scriptVie.OnTakeMedicine(25);
    }

    private void PrendreSpeed(GameObject joueur)
    {
        var scriptVitesse = joueur.GetComponent<mouvementJoueur>();
        scriptVitesse.AugmenterVitesseDeBase(15f, 5f);
    }

    private void PrendreMorphine(GameObject joueur)
    {

    }

    private void PrendreNeon(GameObject joueur)
    {

    }




}
