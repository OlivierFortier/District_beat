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
                    PrendrePackVie();
                    break;

                case TypeItem.Speed:
                    PrendreSpeed();
                    break;

                case TypeItem.Morphine:
                    PrendreMorphine();
                    break;

                case TypeItem.Neon:
                    PrendreNeon();
                    break;

                default:
                    PrendrePackVie();
                    break;
            }

        }
    }

    private void PrendrePackVie()
    {

    }

    private void PrendreSpeed()
    {

    }

    private void PrendreMorphine()
    {

    }

    private void PrendreNeon()
    {

    }




}
