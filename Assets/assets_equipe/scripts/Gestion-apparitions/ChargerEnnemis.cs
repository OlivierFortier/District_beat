using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargerEnnemis : MonoBehaviour
{

    public ControlleurApparition controlleur;

    private void OnTriggerEnter(Collider autreObjet) {
        if(autreObjet.transform.CompareTag("joueur")) {

         

            controlleur.enabled = true;
            
        }
    }

}
