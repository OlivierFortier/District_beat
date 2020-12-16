using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

// Olivier Fortier
// script qui gère la caméra qui s'adapte au nombre de joueurs
public class GestionCameraMulti : MonoBehaviour
{

// référence au groupe de cibles de la caméra cinemachine
   public CinemachineTargetGroup groupeCamera;


    void Start()
    {
        // trouver tous les joueurs
        var arrJoueurs = GameObject.FindGameObjectsWithTag("joueur");

        // pour chaque joueur, l'ajouter au groupe de caméra
        foreach (GameObject joueur in arrJoueurs) {
            groupeCamera.AddMember(joueur.transform, 1f, 3.12f);
        }
    }

}
