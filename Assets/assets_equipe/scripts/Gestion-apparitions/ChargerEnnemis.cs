using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Olivier Fortier
// script qui active le chargement des ennemis lorsqu'on entre dans une salle
public class ChargerEnnemis : MonoBehaviour
{

    // référence au script de création d'ennemis
    public ControlleurApparition controlleur;

    // activer le script de création d'ennemis quand on entre dans la salle
    private void OnTriggerEnter(Collider autreObjet) {
        if(autreObjet.transform.CompareTag("joueur")) {

            controlleur.enabled = true;
            // désactiver le détecteur d'entrée
            Destroy(gameObject, 1f);
        }
    }

}
